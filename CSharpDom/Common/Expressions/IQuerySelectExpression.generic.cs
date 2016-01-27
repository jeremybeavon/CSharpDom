namespace CSharpDom.Common.Expressions
{
    public interface IQuerySelectExpression<TExpression> : IQuerySelectExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
