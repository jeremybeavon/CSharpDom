using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class SolutionWithSymbols : AbstractAsyncSymbolNode<ISolutionWithSymbols>
    {
        private readonly ISolutionWithSymbols solution;

        private SolutionWithSymbols(ISolutionWithSymbols solution)
            : base(solution)
        {
            this.solution = solution;
        }

        public IReadOnlyCollection<ProjectWithSymbols> Projects
        {
            get
            {
                return new ReadOnlyNodeCollection<ProjectWithSymbols, IProjectWithSymbols>(
                    solution.Projects,
                    project => ProjectWithSymbols.GetProject(project));
            }
        }

        public Solution Solution
        {
            get { return solution.Solution; }
        }

        public static SolutionWithSymbols GetSolution(ISolutionWithSymbols solution)
        {
            return solution == null ? null : new SolutionWithSymbols(solution);
        }

        public static async Task<SolutionWithSymbols> OpenSolutionAsync(string solutionFile)
        {
            return GetSolution(await SymbolFactory.OpenSolutionAsync(solutionFile));
        }

        public static SolutionWithSymbols OpenSolution(Solution solution)
        {
            return GetSolution(SymbolFactory.OpenSolution(solution));
        }

        public override Task AcceptAsync(SymbolsVisitor visitor)
        {
            return solution.AcceptAsync(new SymbolsVisitorMapping(visitor));
        }
    }
}
