namespace CSharpDom.Common.Expressions
{
    public interface IQueryJoinExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        TIdentifierExpression JoinExpression { get; }

        TExpression InExpression { get; }

        TExpression OnExpression { get; }

        TExpression EqualsExpression { get; }

        TIdentifierExpression IntoExpression { get; }
    }
}
