namespace CSharpDom.Common.Expressions
{
    public interface IQueryWhereExpression<TExpression> : IQueryWhereExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
