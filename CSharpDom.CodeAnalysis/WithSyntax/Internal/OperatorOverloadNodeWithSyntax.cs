using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class OperatorOverloadNodeWithSyntax : OperatorOverloadNode, IOperatorOverloadSyntax
    {
        public OperatorOverloadNodeWithSyntax(OperatorDeclarationSyntax declaration, IMemberContainer container)
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
            return new OperatorOverloadWithSyntax(this);
        }
    }
}
