using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public static class LinqExpressionFactory
    {
        public static Task<ISolutionWithLinqExpressions> OpenSolutionAsync(string solutionFile)
        {
            return SolutionNode.OpenAsync(solutionFile, OpenSolution);
        }

        public static ISolutionWithLinqExpressions OpenSolution(Solution solution)
        {
            return new SolutionNodeWithLinqExpressions(solution, new AppDomainAssemblyLoader());
        }

        public static Task<ISolutionWithLinqExpressions> OpenSolutionAsync(string solutionFile, string assemblyDirectory)
        {
            return SolutionNode.OpenAsync(solutionFile, solution => OpenSolution(solution, assemblyDirectory));
        }

        public static ISolutionWithLinqExpressions OpenSolution(Solution solution, string assemblyDirectory)
        {
            return new SolutionNodeWithLinqExpressions(solution, new DirectoryAssemblyLoader(assemblyDirectory));
        }
    }
}
