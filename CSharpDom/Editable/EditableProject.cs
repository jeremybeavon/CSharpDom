using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableProject<TSolution, TDocument, TLoadedProject> :
        IProject<TSolution, TDocument, TLoadedProject>
        where TSolution : ISolution
        where TDocument : IDocument
        where TLoadedProject : ILoadedProject
    {
        public abstract ICollection<TDocument> Documents { get; set; }

        public abstract TSolution Solution { get; set; }

        IReadOnlyCollection<TDocument> IHasDocuments<TDocument>.Documents
        {
            get { return new ReadOnlyCollectionWrapper<TDocument>(Documents); }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitProjectAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitProjectChildrenAsync(this, visitor);
        }

        public abstract Task<TLoadedProject> LoadAsync();
    }
}
