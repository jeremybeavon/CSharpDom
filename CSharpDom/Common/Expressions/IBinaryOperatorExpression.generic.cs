namespace CSharpDom.Common.Expressions
{
    public interface IBinaryOperatorExpression<TExpression> : IBinaryOperatorExpression
        where TExpression : IExpression
    {
        TExpression Left { get; }

        BinaryOperatorExpressionType OperatorType { get; }

        TExpression Right { get; }
    }
}
