using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class BaseTypeList<TParentNode, TParentSyntax> :
        WrappedChildSyntaxList<TParentSyntax, BaseTypeSyntax, NameSyntax>
        where TParentSyntax : TypeDeclarationSyntax
    {
        public BaseTypeList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<BaseTypeSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<BaseTypeSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateChildSyntaxList(node, getList, createList))
        {
        }

        private BaseTypeList(IChildSyntaxList<TParentSyntax, BaseTypeSyntax> list)
            : base(
                  list,
                  syntax => (NameSyntax)syntax.Type,
                  syntax => list.FirstOrDefault(typeSyntax => typeSyntax.Type == syntax) ?? SyntaxFactory.SimpleBaseType(syntax))
        {
        }
    }
}
