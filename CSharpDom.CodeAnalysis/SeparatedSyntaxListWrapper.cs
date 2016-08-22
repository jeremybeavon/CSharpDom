using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class SeparatedSyntaxListWrapper<T, TSyntax, TParent> : ImmutableListWrapper<T, TSyntax, TParent>
        where T : class, IHasSyntax<TSyntax>, IHasId
        where TSyntax : SyntaxNode
        where TParent : class
    {
        public SeparatedSyntaxListWrapper(
            Func<SeparatedSyntaxList<TSyntax>> getSyntaxList,
            Action<SeparatedSyntaxList<TSyntax>> setSyntaxList,
            Func<T> factory,
            TParent parent,
            Action<T, TParent> setParent)
            : base(new ImmutableSeparatedSyntaxListWrapper<TSyntax>(getSyntaxList, setSyntaxList), factory, parent, setParent)
        {
        }
    }
}
