namespace CSharpDom.Common.Expressions
{
    public interface IParenthesisExpression<TExpression> : IParenthesisExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
