using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class EventPropertyNode : AbstractMemberNode<EventDeclarationSyntax>,
        IPropertyModifier<EventDeclarationSyntax>
    {
        protected EventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container)
            : base(declaration, container)
        {
        }

        public string Name
        {
            get { return Declaration.Identifier.ToString(); }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public EventDeclarationSyntax WithAccessors(EventDeclarationSyntax property, AccessorListSyntax accessors)
        {
            return property.WithAccessorList(accessors);
        }

        public EventDeclarationSyntax WithAttributeLists(
            EventDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public EventDeclarationSyntax WithModifiers(EventDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
