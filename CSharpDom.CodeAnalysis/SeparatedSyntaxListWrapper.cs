﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : class
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SeparatedSyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
            : base(node, ListFactory.CreateList(node, getList, createList), factory, setParent)
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<TChildNode> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.SeparatedList(newList.Select(item => item.Syntax)));
        }
    }
}