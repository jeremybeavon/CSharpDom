using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class ConstructorNode : AbstractMemberNode<ConstructorDeclarationSyntax>,
        IMethodModifier<ConstructorDeclarationSyntax>
    {
        protected ConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        ConstructorDeclarationSyntax IMemberModifier<ConstructorDeclarationSyntax>.Declaration
        {
            get { return Declaration.WithInitializer(null); }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public ConstructorDeclarationSyntax WithAttributeLists(
            ConstructorDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public ConstructorDeclarationSyntax WithBody(ConstructorDeclarationSyntax method, BlockSyntax body)
        {
            return method.WithBody(body);
        }

        public ConstructorDeclarationSyntax WithModifiers(ConstructorDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
