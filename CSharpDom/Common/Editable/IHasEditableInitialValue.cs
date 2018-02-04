namespace CSharpDom.Common.Editable
{
    public interface IHasEditableInitialValue<TExpression> : IHasInitialValue<TExpression>
    {
        new TExpression InitialValue { get; set; }
    }
}