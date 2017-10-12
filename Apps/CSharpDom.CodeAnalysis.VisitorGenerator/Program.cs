using CSharpDom.CodeGeneration.Tree;
using CSharpDom.Reflection;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.VisitorGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //AsyncContext.Run(GenerateVisitorInterface);
            string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\.."));
            AssemblyWithReflection assembly = new AssemblyWithReflection(typeof(ClassWithCodeAnalysis).Assembly);
            Interface visitorInterface = new Interface("ICodeAnalysisVisitor");
            IEnumerable<string> classNames =
                from @class in assembly.AllClasses
                let baseClassName = @class.BaseClass?.Name
                where baseClassName != null &&
                    baseClassName.StartsWith("Editable") &&
                    !baseClassName.Contains("Expression") &&
                    !baseClassName.Contains("Statement")
                let className = @class.Name
                orderby className
                select className;
            foreach (string className in classNames)
            {
                string parameterName = Regex.Replace(className, "WithCodeAnalysis$", "");
                parameterName = parameterName.Substring(0, 1).ToLower() + parameterName.Substring(1);
                InterfaceMethod method = new InterfaceMethod($"Visit{className}")
                {
                    ReturnType = new TypeReference(typeof(void)),
                    Parameters = new Collection<MethodParameter>()
                    {
                        new MethodParameter(parameterName, new TypeReference(className))
                    }
                };
                visitorInterface.Body.Methods.Add(method);
            }

            Console.WriteLine(visitorInterface.ToString());
        }

        private static async Task GenerateVisitorInterface()
        {
            string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\.."));
            ProjectWithCodeAnalysis project = await ProjectWithCodeAnalysis.OpenAsync(
                Path.Combine(baseDirectory, @"CSharpDom.CodeAnalysis\CSharpDom.CodeAnalysis.csproj"));
            LoadedProjectWithCodeAnalysis loadedProject = await project.LoadAsync();
            Interface visitorInterface = new Interface("ICodeAnalysisVisitor");
            IEnumerable<string> classNames =
                from @class in loadedProject.AllClasses
                let baseClassName = @class.BaseClass?.Name
                where baseClassName != null &&
                    baseClassName.StartsWith("Editable") &&
                    !baseClassName.Contains("Expression") &&
                    !baseClassName.Contains("Statement")
                let className = @class.Name
                orderby className
                select className;
            foreach (string className in classNames)
            {
                string parameterName = Regex.Replace(className, "WithCodeAnalysis$", "");
                parameterName = parameterName.Substring(0, 1).ToLower() + parameterName.Substring(1);
                InterfaceMethod method = new InterfaceMethod($"Visit{className}")
                {
                    ReturnType = new TypeReference(typeof(void)),
                    Parameters = new Collection<MethodParameter>()
                    {
                        new MethodParameter(parameterName, new TypeReference(className))
                    }
                };
                visitorInterface.Body.Methods.Add(method);
            }

            Console.WriteLine(visitorInterface.ToString());
        }
    }
}
