using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ProjectWrapper : AbstractAsyncWrapper<IProject>, IProjectWrapper
    {
        private Func<IReadOnlyCollection<IDocumentWrapper>> documents;
        private Func<ISolutionWrapper> solution;

        public ProjectWrapper(IProject project)
            : base(project)
        {
        }

        public IReadOnlyCollection<IDocumentWrapper> Documents
        {
            get { return documents(); }
        }

        public ISolutionWrapper Solution
        {
            get { return solution(); }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitProjectAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitProjectChildrenAsync(this, visitor);
        }

        public Task<ILoadedProjectWrapper> LoadAsync()
        {
            throw new NotImplementedException();
        }

        public override async Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(
            IProject<TSolution, TDocument, TLoadedProject> project)
        {
            documents = () => new ReadOnlyCollectionWrapper<TDocument, IDocumentWrapper>(
                project.Documents,
                input => new DocumentWrapper(input));
            solution = () => new SolutionWrapper(project.Solution);
        }
    }
}
