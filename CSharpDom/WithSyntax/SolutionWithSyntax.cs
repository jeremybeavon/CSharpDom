using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSyntax
{
    public sealed class SolutionWithSyntax : AbstractAsyncSyntaxNode<ISolutionSyntax>
    {
        private readonly ISolutionSyntax solution;

        private SolutionWithSyntax(ISolutionSyntax solution)
            : base(solution)
        {
            this.solution = solution;
        }

        public IReadOnlyCollection<ProjectWithSyntax> Projects
        {
            get
            {
                return new ReadOnlyNodeCollection<ProjectWithSyntax, IProjectSyntax>(
                    solution.Projects,
                    project => ProjectWithSyntax.GetProject(project));
            }
        }

        public Solution Solution
        {
            get { return solution.Solution; }
        }

        public static SolutionWithSyntax GetSolution(ISolutionSyntax solution)
        {
            return solution == null ? null : new SolutionWithSyntax(solution);
        }

        public static async Task<SolutionWithSyntax> OpenSolutionAsync(string solutionFile)
        {
            return GetSolution(await SyntaxFactory.OpenSolutionAsync(solutionFile));
        }

        public static SolutionWithSyntax OpenSolution(Solution solution)
        {
            return GetSolution(SyntaxFactory.OpenSolution(solution));
        }

        public static SolutionWithSyntax CreateSolutionForText(string sourceText)
        {
            return GetSolution(SyntaxFactory.CreateSolutionForText(sourceText));
        }

        public override Task AcceptAsync(SyntaxVisitor visitor)
        {
            return solution.AcceptAsync(new SyntaxVisitorMapping(visitor));
        }
    }
}
