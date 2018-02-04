using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableField<TExpression> :
        IEditableField,
        IHasEditableName,
        IHasEditableInitialValue<TExpression>,
        IField<TExpression>
        where TExpression : IEditableExpression
    {
    }
}