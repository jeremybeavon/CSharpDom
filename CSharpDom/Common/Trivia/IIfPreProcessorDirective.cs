namespace CSharpDom.Common.Trivia
{
    public interface IIfPreProcessorDirective<TPreProcessorExpression> : IPrePrecessorDirective
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Expression { get; }
    }
}
