using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableOutArgument<TExpression> :
        IEditableArgument<TExpression>,
        IEditableOutArgument,
        IOutArgument<TExpression>
        where TExpression : IEditableExpression
    {
    }
}