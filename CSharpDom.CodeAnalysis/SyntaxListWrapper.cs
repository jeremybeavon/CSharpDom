using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : class
        where TChildSyntax : SyntaxNode
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TParentNode, TChildSyntax, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
            : base(node, ListFactory.CreateList(node, getList, createList), factory, setParent)
        {
            this.node = node;
            this.createList = createList;
        }

        public SyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
            : this(node, getList, createList, (parent, childSyntax) => factory(parent), setParent)
        {
        }

        public void ReplaceList(IEnumerable<TChildNode> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.List(newList.Select(item => item.Syntax)));
        }
    }
}
