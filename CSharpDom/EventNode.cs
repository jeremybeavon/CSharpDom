using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class EventNode : AbstractBasicMemberNode<EventFieldDeclarationSyntax>,
        IMemberModifier<EventFieldDeclarationSyntax>
    {
        protected EventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container)
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

        public EventFieldDeclarationSyntax WithAttributeLists(
            EventFieldDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public EventFieldDeclarationSyntax WithModifiers(EventFieldDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
