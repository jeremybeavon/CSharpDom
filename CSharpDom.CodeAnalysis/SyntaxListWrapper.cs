using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class SyntaxListWrapper<T, TSyntax, TParent> : ImmutableListWrapper<T, TSyntax, TParent>
        where T : class, IHasSyntax<TSyntax>, IHasId
        where TSyntax : SyntaxNode
        where TParent : class
    {
        public SyntaxListWrapper(
            Func<SyntaxList<TSyntax>> getSyntaxList,
            Action<SyntaxList<TSyntax>> setSyntaxList,
            Func<T> factory,
            TParent parent,
            Action<T, TParent> setParent)
            : base(new ImmutableSyntaxListWrapper<TSyntax>(getSyntaxList, setSyntaxList), factory, parent, setParent)
        {
        }
    }
}
