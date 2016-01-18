using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class LoadedDocumentNodeWithSyntax : LoadedDocumentNode
    {
        public LoadedDocumentNodeWithSyntax(DocumentNode document)
            : base(document)
        {
        }

        public override AbstractSyntaxNode CreateNode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
