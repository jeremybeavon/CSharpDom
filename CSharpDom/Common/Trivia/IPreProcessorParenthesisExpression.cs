namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorParenthesisExpression<TPreProcessorExpression> : IPreProcessorExpression
       where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Expression { get; }
    }
}
