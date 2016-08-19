using Microsoft.CodeAnalysis;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class SeparatedSyntaxListWrapper<T, TSyntax> : ImmutableListWrapper<T, TSyntax>
        where T : class, IHasSyntax<TSyntax>, IHasId, IHasParent<T, TSyntax>
        where TSyntax : SyntaxNode
    {
        public SeparatedSyntaxListWrapper(IHasChild<SeparatedSyntaxList<TSyntax>> parent, Func<IHasChildWithId<T, TSyntax>, T> converter)
            : base(new ImmutableSeparatedSyntaxListWrapper<TSyntax>(parent), converter)
        {
        }
    }
}
