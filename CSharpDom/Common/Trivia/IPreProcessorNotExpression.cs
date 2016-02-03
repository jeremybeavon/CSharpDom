namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorNotExpression<TPreProcessorExpression> : IPreProcessorExpression
        where TPreProcessorExpression : IPreProcessorExpression
    {
        TPreProcessorExpression Operand { get; }
    }
}
