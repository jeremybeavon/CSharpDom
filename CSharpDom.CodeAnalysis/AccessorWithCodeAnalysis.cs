using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>,
        IHasNode<AccessorDeclarationSyntax>
    {
        private readonly Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> node;
        private readonly SyntaxKind accessorType;
        private readonly AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> attributes;
        
        internal AccessorWithCodeAnalysis(AccessorType type)
            : this(type == AccessorType.Get ? SyntaxKind.GetKeyword : SyntaxKind.SetKeyword)
        {
        }

        internal AccessorWithCodeAnalysis(SyntaxKind accessorType)
        {
            node = new Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(this);
            this.accessorType = accessorType;
            attributes = new AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> Node
        {
            get { return node; }
        }
        
        INode<AccessorDeclarationSyntax> IHasNode<AccessorDeclarationSyntax>.Node
        {
            get { return node; }
        }
    }
}
