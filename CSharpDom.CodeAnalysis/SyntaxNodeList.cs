using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> :
        ChildNodeList<TParent, TParentSyntax, TChild, TChildSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SyntaxNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }
        
        public SyntaxNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChild> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<TChild> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.List(newList.Select(item => item.Node.Syntax)));
        }
    }
}
