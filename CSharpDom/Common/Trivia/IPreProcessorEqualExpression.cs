namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorEqualExpression<TPreProcessorExpression> : IPreProcessorExpression
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Left { get; }

        bool Right { get; }
    }
}
