using System;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractDocument<TProject, TSolution, TLoadedDocument> :
        IDocument<TProject, TSolution, TLoadedDocument>
        where TProject : IProject
        where TSolution : ISolution
        where TLoadedDocument : ILoadedDocument
    {
        public abstract string FullFilePath { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        public abstract Task<TLoadedDocument> LoadAsync();
    }
}
