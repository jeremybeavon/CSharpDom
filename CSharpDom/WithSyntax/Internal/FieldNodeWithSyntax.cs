using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class FieldNodeWithSyntax : FieldNode, IFieldSyntax
    {
        public FieldNodeWithSyntax(FieldDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new FieldWithSyntax(this);
        }
    }
}
