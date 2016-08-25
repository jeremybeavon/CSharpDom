using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : class
        where TChildSyntax : SyntaxNode
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
    {
        public SyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
            : base(
                  node,
                  ListFactory.CreateList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList), 
                  factory,
                  setParent)
        {
        }

        //public SyntaxListWrapper(
        //    Node<TParentNode, TParentSyntax> node,
        //    Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
        //    Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
        //    Func<TParentNode, TChildNode> factory,
        //    Action<TChildNode, TParentNode> setParent)
        //    : base(
        //          node,
        //          ListFactory.CreateList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList),
        //          factory,
        //          setParent)
        //{
        //}
    }
}
