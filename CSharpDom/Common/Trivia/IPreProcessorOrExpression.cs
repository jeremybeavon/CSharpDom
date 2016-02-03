namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorOrExpression<TPreProcessorExpression> : IPreProcessorExpression
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Left { get; }

        TPreProcessorExpression Right { get; }
    }
}
