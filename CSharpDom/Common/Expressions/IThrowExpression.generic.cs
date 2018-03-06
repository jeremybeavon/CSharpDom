namespace CSharpDom.Common.Expressions
{
    public interface IThrowExpression<TExpression> : IThrowExpression
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
