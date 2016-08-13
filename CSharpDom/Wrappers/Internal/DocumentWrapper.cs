using CSharpDom.Common;
using System.Threading.Tasks;
using System;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DocumentWrapper : AbstractAsyncWrapper<IDocument>, IDocumentWrapper
    {
        private Func<string> fullFilePath;
        private Func<IProjectWrapper> project;
        private Func<ISolutionWrapper> solution;
        private Func<Task<ILoadedDocumentWrapper>> loadedDocument;

        public DocumentWrapper(IDocument document)
            : base(document)
        {
        }

        public string FullFilePath
        {
            get { return fullFilePath(); }
        }

        public IProjectWrapper Project
        {
            get { return project(); }
        }

        public ISolutionWrapper Solution
        {
            get { return solution(); }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        public Task<ILoadedDocumentWrapper> LoadAsync()
        {
            return loadedDocument();
        }

        public override Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document)
        {
            fullFilePath = () => document.FullFilePath;
            project = () => new ProjectWrapper(document.Project);
            solution = () => new SolutionWrapper(document.Solution);
            loadedDocument = async () => new LoadedDocumentWrapper(await document.LoadAsync());
            return EmptyTask;
        }
    }
}
