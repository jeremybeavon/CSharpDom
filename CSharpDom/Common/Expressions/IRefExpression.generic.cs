namespace CSharpDom.Common.Expressions
{
    public interface IRefExpression<TExpression> : IRefExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
