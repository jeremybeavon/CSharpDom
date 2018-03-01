namespace CSharpDom.Common.Editable
{
    public interface IHasEditableLambdaExpression<TExpression>  : IHasLambdaExpression<TExpression>
    {
        new TExpression LambdaExpression { get; set; }
    }
}
