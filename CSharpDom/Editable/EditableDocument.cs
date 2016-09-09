using System;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableDocument<TProject, TSolution, TLoadedDocument> :
        IDocument<TProject, TSolution, TLoadedDocument>
        where TProject : IProject
        where TSolution : ISolution
        where TLoadedDocument : ILoadedDocument
    {
        public abstract string FullFilePath { get; set; }

        public abstract TProject Project { get; set; }

        public abstract TSolution Solution { get; set; }

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
