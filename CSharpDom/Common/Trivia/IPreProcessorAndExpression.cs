namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorAndExpression<TPreProcessorExpression> : IPreProcessorExpression
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Left { get; }

        TPreProcessorExpression Right { get; }
    }
}
