using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredSyntaxListWrapper<T, TSyntax, TChildSyntax, TParent> : ImmutableListWrapper<T, TChildSyntax, TParent>
        where T : class, IHasSyntax<TChildSyntax>, IHasId
        where TSyntax : SyntaxNode
        where TChildSyntax : TSyntax
        where TParent : class
    {
        public FilteredSyntaxListWrapper(
            Func<SyntaxList<TSyntax>> getSyntaxList,
            Action<SyntaxList<TSyntax>> setSyntaxList,
            Func<T> factory,
            TParent parent,
            Action<T, TParent> setParent,
            Func<TChildSyntax, bool> filter = null)
            : base(FilteredListFactory.Create(getSyntaxList, setSyntaxList, filter), factory, parent, setParent)
        {
        }
    }
}
