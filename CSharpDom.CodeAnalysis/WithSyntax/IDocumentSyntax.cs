using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IDocumentSyntax : IDocument<IProjectSyntax, ISolutionSyntax, ILoadedDocumentWithSyntax>, IHasDocument<Document>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
