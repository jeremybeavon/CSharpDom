namespace CSharpDom.Common.Expressions
{
    public interface IUnaryOperatorExpression<TExpression> : IUnaryOperatorExpression
        where TExpression : IExpression
    {
        TExpression Operand { get; }

        UnaryOperatorExpressionType OperatorType { get; }
    }
}
