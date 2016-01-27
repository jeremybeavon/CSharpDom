namespace CSharpDom.Common.Expressions
{
    public interface IQueryGroupExpression<TExpression, TIdentifierExpression> : IQueryGroupExpression
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        TExpression GroupExpression { get; }

        TExpression ByExpression { get; }

        TIdentifierExpression IntoExpression { get; }
    }
}
