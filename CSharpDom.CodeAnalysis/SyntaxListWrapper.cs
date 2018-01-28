using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList;

        public SyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            : base(node, ListFactory.CreateChildSyntaxList(node, getList, createList), factory)
        {
            this.node = node;
            this.createList = createList;
        }
        
        public SyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildNode> factory)
            : this(node, getList, createList, syntax => factory())
        {
        }

        public void ReplaceList(IEnumerable<TChildNode> newList)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.List(newList.Select(item => item.Node.Syntax)));
        }
    }
}
