using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal class BaseTypeListWrapper<TParentNode, TParentSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>
        where TParentNode : class
        where TParentSyntax : TypeDeclarationSyntax
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList;

        public BaseTypeListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList,
            Func<TParentNode, InterfaceReferenceWithCodeAnalysis> factory,
            Action<InterfaceReferenceWithCodeAnalysis, TParentNode> setParent)
            : base(node, ListFactory.CreateBaseTypeList(node, createList), factory, setParent)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<InterfaceReferenceWithCodeAnalysis> newList)
        {
            TParentSyntax syntax = node.Syntax;
            SeparatedSyntaxList<BaseTypeSyntax> baseTypes =
                SyntaxFactory.SeparatedList(newList.Select(item => (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(item.Syntax)));
            node.Syntax = createList(syntax, syntax.BaseList.WithTypes(baseTypes));
        }
    }
}
