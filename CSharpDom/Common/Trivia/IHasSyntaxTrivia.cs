using System.Collections.Generic;

namespace CSharpDom.Common.Trivia
{
    public interface IHasSyntaxTrivia<TSyntaxTrivia>
    {
        IReadOnlyList<TSyntaxTrivia> Trivia { get; }
    }
}
