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
        private readonly AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> attributes;

        internal AccessorWithCodeAnalysis()
        {
            node = new Node<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(this);
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
            set { Syntax = Syntax.WithAttributeLists(SyntaxFactory.List(value.Select(node => node.Syntax))); }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal AttributeListWrapper<AccessorWithCodeAnalysis, AccessorDeclarationSyntax> AttributeList
        {
            get { return attributes; }
        }

        internal TParent GetParent<TParent>()
            where TParent : class
        {
            return node.GetParentNode<TParent>();
        }
    }
}
