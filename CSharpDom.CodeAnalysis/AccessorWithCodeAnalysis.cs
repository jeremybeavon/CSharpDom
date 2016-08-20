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
        private readonly Func<AccessorDeclarationSyntax> getAccessor;
        private readonly Action<AccessorDeclarationSyntax> setAccessor;
        private SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis> attributes;

        internal AccessorWithCodeAnalysis()
        {
            attributes = new SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis>(
                () => getAccessor().AttributeLists,
                list => setAccessor(getAccessor().WithAttributeLists(list)),
                () => new AttributeGroupWithCodeAnalysis(this),
                this,
                (child, newParent) => { });
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { setAccessor(getAccessor().WithAttributeLists(SyntaxFactory.List(value.Select(node => node.Syntax)))); }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return getAccessor(); }
        }

        internal SyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AccessorWithCodeAnalysis> AttributeList
        {
            get { return attributes; }
        }
    }
}
