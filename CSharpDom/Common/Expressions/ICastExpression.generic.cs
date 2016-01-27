namespace CSharpDom.Common.Expressions
{
    public interface ICastExpression<TTypeReference, TExpression> : ICastExpression
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        TTypeReference Type { get; }

        TExpression Expression { get; }
    }
}
