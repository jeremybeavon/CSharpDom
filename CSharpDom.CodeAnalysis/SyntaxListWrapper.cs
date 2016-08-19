using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class SyntaxListWrapper<T, TSyntax> : ImmutableListWrapper<T, TSyntax>
        where T : class, IHasSyntax<TSyntax>, IHasId, IHasParent<T, TSyntax>
        where TSyntax : SyntaxNode
    {
        public SyntaxListWrapper(IHasChild<SyntaxList<TSyntax>> parent, Func<IHasChildWithId<T, TSyntax>, T> converter)
            : base(new ImmutableSyntaxListWrapper<TSyntax>(parent), converter)
        {
        }
    }
}
