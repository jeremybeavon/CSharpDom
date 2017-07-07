namespace CSharpDom.Common.Expressions
{
    public interface IQueryOrderingExpression<TExpression> : IQueryOrderingExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }

        QueryOrderByType OrderByType { get; }
    }
}
