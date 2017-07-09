namespace CSharpDom.Common.Expressions
{
    public interface IQueryGroupExpression<TExpression> : IQueryGroupExpression
        where TExpression : IExpression
    {
        TExpression GroupExpression { get; }

        TExpression ByExpression { get; }
    }
}
