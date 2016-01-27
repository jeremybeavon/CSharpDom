using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class IndexerNode : AbstractBasicMemberNode<IndexerDeclarationSyntax>,
        IPropertyModifier<IndexerDeclarationSyntax>
    {
        protected IndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
            : base(declaration, container)
        {
        }

        public bool HasGet
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasSet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return ToString(DeclaringType, this);
        }

        public IndexerDeclarationSyntax WithAccessors(IndexerDeclarationSyntax property, AccessorListSyntax accessors)
        {
            return property.WithAccessorList(accessors);
        }

        public IndexerDeclarationSyntax WithAttributeLists(
            IndexerDeclarationSyntax member,
            SyntaxList<AttributeListSyntax> attributes)
        {
            return member.WithAttributeLists(attributes);
        }

        public IndexerDeclarationSyntax WithModifiers(IndexerDeclarationSyntax member, SyntaxTokenList modifiers)
        {
            return member.WithModifiers(modifiers);
        }
    }
}
