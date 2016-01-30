using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization
{
    public sealed class Document : IDocument<ProjectNotSupported, SolutionNotSupported, LoadedDocument>
    {
        public string FullFilePath { get; set; }

        public LoadedDocument LoadedDocument  { get; set; }

        public ProjectNotSupported Project
        {
            get { return null; }
        }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        public Task<LoadedDocument> LoadAsync()
        {
            return Task.FromResult(LoadedDocument);
        }
    }
}
