using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public static class ReflectionFactory
    {
        public static Task<ISolutionWithReflection> OpenSolutionAsync(string solutionFile)
        {
            return SolutionNode.OpenAsync(solutionFile, OpenSolution);
        }

        public static ISolutionWithReflection OpenSolution(Solution solution)
        {
            return new SolutionNodeWithReflection(solution, new AppDomainAssemblyLoader());
        }

        public static Task<ISolutionWithReflection> OpenSolutionAsync(string solutionFile, string assemblyDirectory)
        {
            return SolutionNode.OpenAsync(solutionFile, solution => OpenSolution(solution, assemblyDirectory));
        }

        public static ISolutionWithReflection OpenSolution(Solution solution, string assemblyDirectory)
        {
            return new SolutionNodeWithReflection(solution, new DirectoryAssemblyLoader(assemblyDirectory));
        }
    }
}
