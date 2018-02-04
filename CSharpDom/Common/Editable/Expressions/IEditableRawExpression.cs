using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableRawExpression : IEditableExpression, IRawExpression
    {
        new string Expression { get; set; }
    }
}