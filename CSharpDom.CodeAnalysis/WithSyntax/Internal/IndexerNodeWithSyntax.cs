using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class IndexerNodeWithSyntax : IndexerNode, IIndexerSyntax
    {
        public IndexerNodeWithSyntax(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        IBasicTypeSyntax IHasDeclaringType<IBasicTypeSyntax>.DeclaringType
        {
            get { return (IBasicTypeSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new IndexerWithSyntax(this);
        }
    }
}
