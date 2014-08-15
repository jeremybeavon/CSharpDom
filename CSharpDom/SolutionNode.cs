using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace CSharpDom
{
    internal abstract class SolutionNode : AbstractAsyncNode
    {
        protected SolutionNode(Solution solution, INodeFactory nodeFactory)
        {
            Solution = solution;
            NodeFactory = nodeFactory;
            Projects = solution.Projects.Select(project => nodeFactory.CreateProjectNode(project, this)).ToArray();
        }

        public Solution Solution { get; private set; }

        public IReadOnlyCollection<ProjectNode> Projects { get; private set; }

        public INodeFactory NodeFactory { get; private set; }

        public static async Task<TSolution> OpenAsync<TSolution>(
            string solutionFile,
            Func<Solution, TSolution> factory)
        {
            return factory(await MSBuildWorkspace.Create().OpenSolutionAsync(solutionFile));
        }

        public override async Task AcceptAsync(NodeVisitor visitor)
        {
            foreach (ProjectNode project in Projects)
            {
                await visitor.VisitProjectAsync(project);
            }
        }
    }
}
