using CSharpDom.Common.Trivia;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IToken
    {
        IReadOnlyList<ISyntaxTrivia> LeadingTrivia { get; }

        string Text { get; }

        IReadOnlyList<ISyntaxTrivia> TrailingTrivia { get; }
    }
}
