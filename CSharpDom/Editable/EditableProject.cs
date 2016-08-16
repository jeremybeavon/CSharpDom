using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableProject<TSolution, TDocument, TLoadedProject> :
        IProject<TSolution, TDocument, TLoadedProject>
        where TSolution : ISolution
        where TDocument : IDocument
        where TLoadedProject : ILoadedProject
    {
        public virtual IReadOnlyCollection<TDocument> Documents { get; set; }

        public virtual TSolution Solution { get; set; }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitProjectAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitProjectChildrenAsync(this, visitor);
        }

        public virtual Task<TLoadedProject> LoadAsync()
        {
            return null;
        }
    }
}
