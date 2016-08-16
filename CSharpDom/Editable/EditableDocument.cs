using System;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableDocument<TProject, TSolution, TLoadedDocument> :
        IDocument<TProject, TSolution, TLoadedDocument>
        where TProject : IProject
        where TSolution : ISolution
        where TLoadedDocument : ILoadedDocument
    {
        public virtual string FullFilePath { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        public virtual Task<TLoadedDocument> LoadAsync()
        {
            return null;
        }
    }
}
