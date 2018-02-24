using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableRefArgument<TExpression> :
        IEditableArgument<TExpression>,
        IEditableRefArgument,
        IRefArgument<TExpression>
        where TExpression : IEditableExpression
    {
    }
}