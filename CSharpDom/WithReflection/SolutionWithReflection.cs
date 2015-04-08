using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class SolutionWithReflection
    {
        private readonly ISolutionWithReflection solution;

        private SolutionWithReflection(ISolutionWithReflection solution)
        {
            this.solution = solution;
        }

        public IReadOnlyCollection<ProjectWithReflection> Projects
        {
            get
            {
                return new ReadOnlyNodeCollection<ProjectWithReflection, IProjectWithReflection>(
                    solution.Projects,
                    project => ProjectWithReflection.GetProject(project));
            }
        }

        public Solution Solution
        {
            get { return solution.Solution; }
        }

        public static SolutionWithReflection GetSolution(ISolutionWithReflection solution)
        {
            return solution == null ? null : new SolutionWithReflection(solution);
        }

        public static async Task<SolutionWithReflection> OpenSolutionAsync(string solutionFile)
        {
            return GetSolution(await ReflectionFactory.OpenSolutionAsync(solutionFile));
        }

        public static async Task<SolutionWithReflection> OpenSolutionAsync(string solutionFile, string assemblyDirectory)
        {
            return GetSolution(await ReflectionFactory.OpenSolutionAsync(solutionFile, assemblyDirectory));
        }

        public Task AcceptAsync(ReflectionVisitor visitor)
        {
            return solution.AcceptAsync(new ReflectionVisitorMapping(visitor));
        }
    }
}
