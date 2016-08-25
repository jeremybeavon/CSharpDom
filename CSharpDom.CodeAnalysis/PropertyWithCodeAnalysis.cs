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
            IClassType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> node;
        private readonly IClassType declaringType;
        private readonly AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> attributes;
        private readonly CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, ITypeReferenceWithCodeAnalysis> propertyType;
        private readonly CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis> getAccessor;
        private readonly CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis> setAccessor;

        internal PropertyWithCodeAnalysis(IClassType declaringType)
        {
            node = new Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(this);
            this.declaringType = declaringType;
            attributes = new AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                null, null);
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

        private CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis>(
                node,
                syntax => GetAccessorDeclaration(syntax, kind) == null ? null : new AccessorWithCodeAnalysis(this, kind),
                (syntax, value) => CreateAccessor(syntax, value, kind),
                (child, parent) => child.Parent = parent);
        }
        
        private PropertyDeclarationSyntax CreateAccessor(
            PropertyDeclarationSyntax syntax,
            AccessorWithCodeAnalysis value,
            SyntaxKind kind)
        {
            AccessorDeclarationSyntax childSyntax = GetAccessorDeclaration(syntax, kind);
            SyntaxList<AccessorDeclarationSyntax>? newList = null;
            if (value == null)
            {
                if (childSyntax != null)
                {
                    newList = syntax.AccessorList.Accessors.Remove(childSyntax);
                }
            }
            else if (childSyntax == null)
            {
                newList = syntax.AccessorList.Accessors.Add(value.Syntax);
            }
            else
            {
                newList = syntax.AccessorList.Accessors.Replace(childSyntax, value.Syntax);
            }

            if (newList != null)
            {
                syntax = syntax.WithAccessorList(syntax.AccessorList.WithAccessors(newList.Value));
            }

            return syntax;
        }

        private AccessorDeclarationSyntax GetAccessorDeclaration(PropertyDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.Accessors.FirstOrDefault(accessor => accessor.Keyword.Kind() == kind);
        }
    }
}
