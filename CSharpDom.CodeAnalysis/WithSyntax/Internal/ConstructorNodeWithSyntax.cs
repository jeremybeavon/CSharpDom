using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class ConstructorNodeWithSyntax : ConstructorNode, IConstructorSyntax
    {
        public ConstructorNodeWithSyntax(ConstructorDeclarationSyntax declaration, IMemberContainer container)
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
            return new ConstructorWithSyntax(this);
        }
    }
}
