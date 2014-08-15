using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class PropertyNode : AbstractBasicMemberNode<PropertyDeclarationSyntax>,
        IPropertyModifier<PropertyDeclarationSyntax>
    {
        protected PropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        public bool HasGet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HasSet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get { return Declaration.Identifier.ToString(); }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public PropertyDeclarationSyntax WithAccessors(PropertyDeclarationSyntax property, AccessorListSyntax accessors)
        {
            return property.WithAccessorList(accessors);
        }

        public PropertyDeclarationSyntax WithAttributeLists(
            PropertyDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public PropertyDeclarationSyntax WithModifiers(PropertyDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
