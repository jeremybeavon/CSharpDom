using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class PropertyWithCodeAnalysis :
        EditableProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object property;
        private readonly Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> node;
        private readonly AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> attributes;
        private readonly CachedTypeReferenceNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> propertyType;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> getAccessor;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> setAccessor;
        
        internal PropertyWithCodeAnalysis(object property)
        {
            node = new Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(this);
            this.property = property;
            attributes = new AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            propertyType = new CachedTypeReferenceNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor.Value; }
            set { getAccessor.Value = value; }
        }
        
        public override string Name
        {
            get { return node.Syntax.Identifier.Text; }
            set { node.Syntax = node.Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return propertyType.Value; }
            set { propertyType.Value = value; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor.Value; }
            set { setAccessor.Value = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        internal Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> Node
        {
            get { return node; }
        }
        
        private CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                () => new AccessorWithCodeAnalysis(kind),
                syntax => GetAccessorDeclaration(syntax, kind),
                (parentSyntax, childSyntax) => CreateAccessor(kind)(parentSyntax, childSyntax));
        }
        
        internal static Func<PropertyDeclarationSyntax, AccessorDeclarationSyntax, PropertyDeclarationSyntax> CreateAccessor(
            SyntaxKind kind)
        {
            return (PropertyDeclarationSyntax parentSyntax, AccessorDeclarationSyntax childSyntax) =>
                parentSyntax.WithAccessorList(parentSyntax.AccessorList.WithAccessor(childSyntax, kind));
        }

        internal static AccessorDeclarationSyntax GetAccessorDeclaration(PropertyDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.GetAccessorDeclaration(kind);
        }
        
        T ISimpleMember.Member<T>()
        {
            return (T)property;
        }
    }
}
