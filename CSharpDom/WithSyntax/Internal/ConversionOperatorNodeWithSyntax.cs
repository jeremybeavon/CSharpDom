using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class ConversionOperatorNodeWithSyntax : ConversionOperatorNode, IConversionOperatorSyntax
    {
        public ConversionOperatorNodeWithSyntax(ConversionOperatorDeclarationSyntax declaration, IMemberContainer container)
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
            return new ConversionOperatorWithSyntax(this);
        }
    }
}
