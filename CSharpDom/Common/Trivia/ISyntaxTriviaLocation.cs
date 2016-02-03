using System.Collections.Generic;

namespace CSharpDom.Common.Trivia
{
    public interface ISyntaxTriviaLocation<TLocationType> : IVisitable<ISyntaxTriviaVisitor>
    {
        TLocationType Location { get; }

        IReadOnlyList<ISyntaxTrivia> SyntaxTrivia { get; }
    }
}
