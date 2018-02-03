using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SeparatedSyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> :
        ChildNodeList<TParent, TParentSyntax, TChild, TChildSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SeparatedSyntaxNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public SeparatedSyntaxNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChild> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<TChild> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.SeparatedList(newList.Select(item => item.Node.Syntax)));
        }
    }
}
