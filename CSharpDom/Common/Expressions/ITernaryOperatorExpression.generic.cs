namespace CSharpDom.Common.Expressions
{
    public interface ITernaryOperatorExpression<TExpression> : ITernaryOperatorExpression
        where TExpression : IExpression
    {
        TExpression Left { get; }

        TExpression Middle { get; }

        TExpression Right { get; }
    }
}
