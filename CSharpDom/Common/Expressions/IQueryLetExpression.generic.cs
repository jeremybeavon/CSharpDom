namespace CSharpDom.Common.Expressions
{
    public interface IQueryLetExpression<TBinaryOperatorExpression> : IQueryLetExpression
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        TBinaryOperatorExpression Expression { get; }
    }
}
