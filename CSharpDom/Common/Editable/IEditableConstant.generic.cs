using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableConstant<TExpression> :
        IEditableConstant,
        IHasEditableName,
        IHasEditableConstantValue<TExpression>,
        IConstant<TExpression>
        where TExpression : IEditableExpression
    {
    }
}