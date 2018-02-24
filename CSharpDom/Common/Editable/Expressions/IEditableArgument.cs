using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableArgument : IVisitable<IEditableExpressionVisitor>, IArgument, IHasEditableName
    {
    }
}
