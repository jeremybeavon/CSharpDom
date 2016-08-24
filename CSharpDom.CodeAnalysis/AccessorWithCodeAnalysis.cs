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
        private readonly Node<AccessorDeclarationSyntax> node;
        private SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis> attributes;

        internal AccessorWithCodeAnalysis()
        {
            node = new Node<AccessorDeclarationSyntax>();
            attributes = new SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis>(
                () => node.Syntax.AttributeLists,
                list => node.Syntax = node.Syntax.WithAttributeLists(list),
                () => new AttributeGroupWithCodeAnalysis(this),
                this,
                (child, newParent) => { });
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

        internal SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis> AttributeList
        {
            get { return attributes; }
        }
    }
}
