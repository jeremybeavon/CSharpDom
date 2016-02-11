namespace CSharpDom.Common
{
    public interface IHasInitialValue<TExpression>
    {
        TExpression InitialValue { get; }
    }
}
