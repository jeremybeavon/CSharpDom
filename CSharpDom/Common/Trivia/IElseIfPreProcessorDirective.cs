namespace CSharpDom.Common.Trivia
{
    public interface IElseIfPreProcessorDirective<TPreProcessorExpression> : IPrePrecessorDirective
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Expression { get; }
    }
}
