using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildBaseClassSyntax, TChildSyntax> :
        ImmutableListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : SyntaxNode
        where TChildNode : class, IHasSyntax<TChildSyntax>, IHasId
        where TChildBaseClassSyntax : SyntaxNode
        where TChildSyntax : TChildBaseClassSyntax
    {
        public FilteredSyntaxListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseClassSyntax>> getSyntaxList,
            Func<TParentSyntax, SyntaxList<TChildBaseClassSyntax>, TParentSyntax> setSyntaxList,
            Func<TParentNode, TChildNode> factory,
            Action<TChildNode, TParentNode> setParent,
            Func<TChildSyntax, bool> filter = null)
            : base(node, ListFactory.CreateFilteredList(node, getSyntaxList, setSyntaxList, filter), factory, setParent)
        {
        }
    }
}
