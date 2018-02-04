namespace CSharpDom.Common.Editable
{
    public interface IHasEditableConstantValue<TExpression> : IHasConstantValue<TExpression>
    {
        new TExpression ConstantValue { get; set; }
    }
}