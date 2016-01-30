using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class Project : IProject<SolutionNotSupported, Document, LoadedProjectNotSupported>
    {
        public Project()
        {
            Documents = new List<Document>();
        }

        public List<Document> Documents { get; set; }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        IReadOnlyCollection<Document> IHasDocuments<Document>.Documents
        {
            get { return Documents; }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitProjectChildrenAsync(this, visitor);
        }

        public Task<LoadedProjectNotSupported> LoadAsync()
        {
            return null;
        }
    }
}
