using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class FieldNode : AbstractMemberNode<FieldDeclarationSyntax>,
        IMemberModifier<FieldDeclarationSyntax>
    {
        protected FieldNode(FieldDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public string Name
        {
            get { return Declaration.Declaration.Variables[0].Identifier.ToString(); }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public FieldDeclarationSyntax WithAttributeLists(
            FieldDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public FieldDeclarationSyntax WithModifiers(FieldDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
