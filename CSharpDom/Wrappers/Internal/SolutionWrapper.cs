using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SolutionWrapper : AbstractAsyncWrapper<ISolution>, ISolutionWrapper
    {
        private Func<IReadOnlyCollection<IProjectWrapper>> projects;

        public SolutionWrapper(ISolution solution)
            : base(solution)
        {
        }

        public IReadOnlyCollection<IProjectWrapper> Projects
        {
            get { return projects(); }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitSolutionAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitSolutionChildrenAsync(this, visitor);
        }

        public override Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
        {
            projects = () => new ReadOnlyCollectionWrapper<TProject, IProjectWrapper>(
                solution.Projects,
                input => new ProjectWrapper(input));
            return Task.FromResult<object>(null);
        }
    }
}
