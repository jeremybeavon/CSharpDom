using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractProject<TSolution, TDocument, TLoadedProject> :
        IProject<TSolution, TDocument, TLoadedProject>
        where TSolution : ISolution
        where TDocument : IDocument
        where TLoadedProject : ILoadedProject
    {
        public abstract IReadOnlyCollection<TDocument> Documents { get; }

        public abstract TSolution Solution { get; }

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
