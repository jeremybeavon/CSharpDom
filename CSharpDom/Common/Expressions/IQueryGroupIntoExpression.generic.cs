namespace CSharpDom.Common.Expressions
{
    public interface IQueryGroupIntoExpression<TExpression, TIdentifierExpression> :
        IQueryGroupIntoExpression,
        IQueryGroupExpression<TExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        TIdentifierExpression IntoExpression { get; }
    }
}
