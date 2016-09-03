using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class BaseTypeList<TParentNode, TParentSyntax> : WrappedList<BaseTypeSyntax, NameSyntax>
        where TParentSyntax : TypeDeclarationSyntax
    {
        public BaseTypeList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<BaseTypeSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<BaseTypeSyntax>, TParentSyntax> createList)
            : base(
                  ListFactory.CreateList(node, getList, createList),
                  syntax => (NameSyntax)syntax.Type,
                  syntax => SyntaxFactory.SimpleBaseType(syntax))
        {
        }
    }
}
