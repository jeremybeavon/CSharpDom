using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : class
        where TChildSyntax : SyntaxNode
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
    {
        public SeparatedSyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent)
            : base(node, ListFactory.CreateList(node, getList, createList), factory, setParent)
        {
        }
    }
}
