using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CSharpDom.CodeAnalysis
{
    internal static class CodeAnalysisWorkspace
    {
        private const string MsBuildExePathEnvironmentVariable = "MSBUILD_EXE_PATH";
        private const string MsBuildBackupDirectoryName = "MSBuildDLLs";
        private const string NuGetTargetsRelativePath =
            @"..\..\..\Common7\IDE\CommonExtensions\Microsoft\NuGet\NuGet.targets";
        private const string NuGetTargetsPropertyName = "NuGetRestoreTargets";
        private static readonly object workspaceLock = new object();
        private static bool isAppDomainInitialized;

        internal static MSBuildWorkspace Create()
        {
            lock (workspaceLock)
            {
                string msBuildExePath = CodeAnalysisSettings.MsBuildExePath;
                Dictionary<string, string> properties = new Dictionary<string, string>();
                if (!string.IsNullOrWhiteSpace(msBuildExePath))
                {
                    Environment.SetEnvironmentVariable(MsBuildExePathEnvironmentVariable, msBuildExePath);
                    CopyMsBuildFilesToBackupDirectory();
                    string nuGetTargetsFilePath = Path.GetFullPath(
                        Path.Combine(Path.GetDirectoryName(msBuildExePath), NuGetTargetsRelativePath));
                    if (File.Exists(nuGetTargetsFilePath))
                    {
                        properties.Add(NuGetTargetsPropertyName, nuGetTargetsFilePath);
                    }
                }

                InitializeAppDomain();
                return MSBuildWorkspace.Create(properties);
            }
        }

        private static void CopyMsBuildFilesToBackupDirectory()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string msBuildDllBackupDirectory = Path.Combine(currentDirectory, MsBuildBackupDirectoryName);
            Directory.CreateDirectory(msBuildDllBackupDirectory);
            StringBuilder msBuildDllDeleteFailures = new StringBuilder();
            foreach (string msBuildFile in Directory.GetFiles(currentDirectory, "Microsoft.Build*.dll"))
            {
                try
                {
                    File.Delete(msBuildFile);
                }
                catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException)
                {
                    if (msBuildDllDeleteFailures.Length == 0)
                    {
                        msBuildDllDeleteFailures.Append("Failed to backup Microsoft.Build DLLS. ");
                        msBuildDllDeleteFailures.Append("This may cause functions to fail. ");
                        msBuildDllDeleteFailures.Append("The DLLs that failed to copy were:");
                    }

                    msBuildDllDeleteFailures.AppendLine();
                    msBuildDllDeleteFailures.AppendLine();
                    msBuildDllDeleteFailures.AppendLine(msBuildFile + ":");
                    msBuildDllDeleteFailures.Append(exception.ToString());
                }
            }

            if (msBuildDllDeleteFailures.Length != 0)
            {
                throw new InvalidOperationException(msBuildDllDeleteFailures.ToString());
            }
        }

        private static void InitializeAppDomain()
        {
            if (!isAppDomainInitialized)
            {
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string msBuildExePath = CodeAnalysisSettings.MsBuildExePath;
                    string name = new AssemblyName(args.Name).Name;
                    string msBuildDll = string.IsNullOrWhiteSpace(msBuildExePath) ?
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, MsBuildBackupDirectoryName, name) :
                        Path.Combine(Path.GetDirectoryName(msBuildExePath), name);
                    return File.Exists(msBuildDll) ? Assembly.LoadFrom(msBuildDll) : null;
                };
                isAppDomainInitialized = true;
            }
        }
    }
}
