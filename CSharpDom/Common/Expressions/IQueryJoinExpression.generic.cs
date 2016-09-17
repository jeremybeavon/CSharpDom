namespace CSharpDom.Common.Expressions
{
    public interface IQueryJoinExpression<TExpression> : IQueryJoinExpression
        where TExpression : IExpression
    {
        string JoinVariable { get; }

        TExpression InExpression { get; }

        TExpression OnExpression { get; }

        TExpression EqualsExpression { get; }

        string IntoVariable { get; }
    }
}
