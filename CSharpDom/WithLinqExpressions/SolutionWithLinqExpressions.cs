using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class SolutionWithLinqExpressions
    {
        private readonly ISolutionWithLinqExpressions solution;

        private SolutionWithLinqExpressions(ISolutionWithLinqExpressions solution)
        {
            this.solution = solution;
        }

        public IReadOnlyCollection<ProjectWithLinqExpressions> Projects
        {
            get
            {
                return new ReadOnlyNodeCollection<ProjectWithLinqExpressions, IProjectWithLinqExpressions>(
                    solution.Projects,
                    project => ProjectWithLinqExpressions.GetProject(project));
            }
        }

        public Solution Solution
        {
            get { return solution.Solution; }
        }

        public static SolutionWithLinqExpressions GetSolution(ISolutionWithLinqExpressions solution)
        {
            return solution == null ? null : new SolutionWithLinqExpressions(solution);
        }

        public static async Task<SolutionWithLinqExpressions> OpenSolutionAsync(string solutionFile)
        {
            return GetSolution(await LinqExpressionFactory.OpenSolutionAsync(solutionFile));
        }

        public static async Task<SolutionWithLinqExpressions> OpenSolutionAsync(string solutionFile, string assemblyDirectory)
        {
            return GetSolution(await LinqExpressionFactory.OpenSolutionAsync(solutionFile, assemblyDirectory));
        }

        public Task AcceptAsync(LinqExpressionsVisitor visitor)
        {
            return solution.AcceptAsync(new LinqExpressionsVisitorMapping(visitor));
        }
    }
}
