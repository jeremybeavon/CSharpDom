namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorNotEqualExpression<TPreProcessorExpression> : IPreProcessorExpression
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Left { get; }

        bool Right { get; }
    }
}
