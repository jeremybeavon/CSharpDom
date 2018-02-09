using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class BaseTypeSyntaxList<TParent, TParentSyntax> :
        WrappedChildSyntaxList<TParentSyntax, BaseTypeSyntax, NameSyntax>
        where TParentSyntax : TypeDeclarationSyntax
    {
        public BaseTypeSyntaxList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
            : this(new BaseTypeSyntaxListConversions<TParent, TParentSyntax>(node, createList))
        {
        }
        
        private BaseTypeSyntaxList(BaseTypeSyntaxListConversions<TParent, TParentSyntax> conversions)
            : base(conversions.List, conversions)
        {
        }
    }
}
