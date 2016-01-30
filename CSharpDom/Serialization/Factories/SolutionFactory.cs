using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SolutionFactory : AbstractAsyncFactory<ISolution, Solution>
    {
        public SolutionFactory(ISolution solution)
            : base(solution)
        {
        }

        public override async Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
        {
            List<Project> projects = new List<Project>();
            foreach (TProject project in solution.Projects)
            {
                projects.Add(await new ProjectFactory(project).ValueAsync());
            }

            Value = new Solution()
            {
                Projects = projects
            };
        }
    }
}
