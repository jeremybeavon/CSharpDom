﻿using CSharpDom.Common;
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
            IClassType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> node;
        private readonly IClassType declaringType;
        private readonly AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> propertyType;
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

        internal PropertyWithCodeAnalysis(IClassType declaringType)
        {
            node = new Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(this);
            this.declaringType = declaringType;
            attributes = new AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.PropertyParent = parent);
            propertyType = new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                parent => parent.Syntax.Type.ToTypeReference(),
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax),
                null);
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { node.Syntax = node.Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override IClassType DeclaringType
        {
            get { return declaringType; }
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
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
                parent => GetAccessorDeclaration(parent.Syntax, kind) == null ? null : new AccessorWithCodeAnalysis(this, kind),
                (parentSyntax, childSyntax) => CreateAccessor(kind)(parentSyntax, childSyntax),
                (child, parent) => child.PropertyParent = parent);
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
    }
}
