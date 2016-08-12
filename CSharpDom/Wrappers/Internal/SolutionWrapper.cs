using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SolutionWrapper : AbstractAsyncWrapper<ISolution, Solution>
    {
        public SolutionWrapper(ISolution solution)
            : base(solution)
        {
        }

        public override async Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
        {
            List<Project> projects = new List<Project>();
            foreach (TProject project in solution.Projects)
            {
                projects.Add(await new ProjectWrapper(project).ValueAsync());
            }

            Value = new Solution()
            {
                Projects = projects
            };
        }
    }
}
