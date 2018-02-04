using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNamedAttributeValue<TExpression> :
        IEditableNamedAttributeValue,
        IHasEditableName,
        INamedAttributeValue<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Value { get; set; }
    }
}