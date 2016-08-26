using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> node;
        private readonly SyntaxKind accessorType;
        private readonly AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> attributes;

        internal AccessorWithCodeAnalysis(PropertyWithCodeAnalysis parent, SyntaxKind accessorType)
        {
            node = new Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(this);
            this.accessorType = accessorType;
            attributes = new AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                newParent => new AttributeGroupWithCodeAnalysis(newParent),
                (child, newParent) => child.AccessorParent = newParent);

        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal PropertyWithCodeAnalysis Parent
        {
            get { return node.GetParentNode<PropertyWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode(
                    value,
                    syntax => PropertyWithCodeAnalysis.GetAccessorDeclaration(syntax, accessorType),
                    PropertyWithCodeAnalysis.CreateAccessor(accessorType));
            }
        }

        internal TParent GetParent<TParent>()
            where TParent : class
        {
            return node.GetParentNode<TParent>();
        }
    }
}
