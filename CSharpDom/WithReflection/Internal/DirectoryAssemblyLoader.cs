using System.IO;
using System.Reflection;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class DirectoryAssemblyLoader : IAssemblyLoader
    {
        private readonly string directory;

        public DirectoryAssemblyLoader(string directory)
        {
            this.directory = directory;
        }

        public Assembly LoadAssembly(ProjectNode project)
        {
            return Assembly.LoadFrom(Path.Combine(directory, project.Project.AssemblyName + ".dll"));
        }
    }
}
