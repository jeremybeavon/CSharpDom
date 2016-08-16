using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class ConversionOperatorNode : AbstractMemberNode<ConversionOperatorDeclarationSyntax>,
        IMethodModifier<ConversionOperatorDeclarationSyntax>
    {
        protected ConversionOperatorNode(ConversionOperatorDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public ConversionOperatorDeclarationSyntax WithAttributeLists(
            ConversionOperatorDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public ConversionOperatorDeclarationSyntax WithBody(ConversionOperatorDeclarationSyntax method, BlockSyntax body)
        {
            return method.WithBody(body);
        }

        public ConversionOperatorDeclarationSyntax WithModifiers(
            ConversionOperatorDeclarationSyntax member,
            SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
