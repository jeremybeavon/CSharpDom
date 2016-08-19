using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AccessorWithCodeAnalysis :
        EditableAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasChild<SyntaxList<AttributeListSyntax>>
    {
        private ICollection<AttributeGroupWithCodeAnalysis> attributes;
        private IHasChild<AccessorDeclarationSyntax> parent;

        internal AccessorWithCodeAnalysis(IHasChild<AccessorDeclarationSyntax> parent)
        {
            this.parent = parent;
            attributes = new SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax>(
                this,
                list => new AttributeGroupWithCodeAnalysis(list));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { parent.Child = parent.Child.WithAttributeLists(SyntaxFactory.List(value.Select(node => node.Syntax))); }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return parent.Child; }
        }

        SyntaxList<AttributeListSyntax> IHasChild<SyntaxList<AttributeListSyntax>>.Child
        {
            get { return parent.Child.AttributeLists; }
            set { parent.Child = parent.Child.WithAttributeLists(value); }
        }
    }
}
