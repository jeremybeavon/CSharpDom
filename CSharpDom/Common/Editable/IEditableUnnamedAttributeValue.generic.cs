using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableUnnamedAttributeValue<TExpression> :
        IEditableUnnamedAttributeValue,
        IUnnamedAttributeValue<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Value { get; set; }
    }
}