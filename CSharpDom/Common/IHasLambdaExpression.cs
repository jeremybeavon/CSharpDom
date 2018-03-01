namespace CSharpDom.Common
{
    public interface IHasLambdaExpression<TExpression>
    {
        TExpression LambdaExpression { get; }
    }
}
