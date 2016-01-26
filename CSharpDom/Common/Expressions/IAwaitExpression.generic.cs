namespace CSharpDom.Common.Expressions
{
    public interface IAwaitExpression<TExpression> : IAwaitExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
