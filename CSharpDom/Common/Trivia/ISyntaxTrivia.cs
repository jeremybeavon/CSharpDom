namespace CSharpDom.Common.Trivia
{
    public interface ISyntaxTrivia : IVisitable<ISyntaxTriviaVisitor>
    {
        SyntaxTriviaType SyntaxTriviaType { get; }
    }
}
