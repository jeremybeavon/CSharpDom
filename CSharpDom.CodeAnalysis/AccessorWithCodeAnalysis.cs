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
        private readonly AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> attributes;

        public AccessorWithCodeAnalysis(AccessorType accessorType)
            : this(SyntaxFactory.AccessorDeclaration(GetSyntax(accessorType)))
        {
        }

        internal AccessorWithCodeAnalysis(AccessorDeclarationSyntax initialSyntax)
        {
            node = new Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            if (initialSyntax != null)
            {
                Syntax = initialSyntax;
            }
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

        private static SyntaxKind GetSyntax(AccessorType accessorType)
        {
            return accessorType == AccessorType.Get ? SyntaxKind.GetKeyword : SyntaxKind.SetKeyword;
        }
    }
}
