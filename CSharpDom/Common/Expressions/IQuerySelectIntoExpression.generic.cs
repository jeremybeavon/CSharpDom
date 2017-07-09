namespace CSharpDom.Common.Expressions
{
    public interface IQuerySelectIntoExpression<TExpression, TIdentifierExpression> :
        IQuerySelectIntoExpression,
        IQuerySelectExpression<TExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        TIdentifierExpression IntoExpression { get; }
    }
}
