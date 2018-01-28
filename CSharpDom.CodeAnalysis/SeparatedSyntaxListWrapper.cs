using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SeparatedSyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public SeparatedSyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildNode> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<TChildNode> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.SeparatedList(newList.Select(item => item.Node.Syntax)));
        }
    }
}
