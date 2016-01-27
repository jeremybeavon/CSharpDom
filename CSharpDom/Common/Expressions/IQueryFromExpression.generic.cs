namespace CSharpDom.Common.Expressions
{
    public interface IQueryFromExpression<TIdentifierExpression, TExpression> : IExpression
        where TIdentifierExpression : IIdentifierExpression
        where TExpression : IExpression
    {
        TIdentifierExpression Identifier { get; }

        TExpression Expression { get; }
    }
}
