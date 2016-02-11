namespace CSharpDom.Common
{
    public interface IHasConstantValue<TExpression>
    {
        TExpression ConstantValue { get; }
    }
}
