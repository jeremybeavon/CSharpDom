namespace CSharpDom.Common.Expressions
{
    public interface IOutExpression<TExpression> : IOutExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
