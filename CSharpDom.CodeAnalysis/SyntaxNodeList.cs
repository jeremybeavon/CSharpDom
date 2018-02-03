﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SyntaxNodeList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }
        
        public SyntaxNodeList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildNode> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<TChildNode> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.List(newList.Select(item => item.Node.Syntax)));
        }
    }
}
