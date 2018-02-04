using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableNewExpression :
        IEditableExpression,
        IEditableCreateObjectExpression,
        IEditableCreateListExpression,
        INewExpression
    {
    }
}