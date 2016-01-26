namespace CSharpDom.Common.Expressions
{
    public interface IQueryOrderByExpression<TExpression> : IQueryOrderByExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }

        QueryOrderByType OrderByType { get; }
    }
}
