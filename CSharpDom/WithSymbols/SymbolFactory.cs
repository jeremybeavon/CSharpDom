using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public static class SymbolFactory
    {
        public static Task<ISolutionWithSymbols> OpenSolutionAsync(string solutionFile)
        {
            return SolutionNode.OpenAsync(solutionFile, OpenSolution);
        }

        public static ISolutionWithSymbols OpenSolution(Solution solution)
        {
            return new SolutionNodeWithSymbols(solution);
        }
    }
}
