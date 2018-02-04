using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableDefaultExpression<TTypeReference> :
        IEditableDefaultExpression,
        IDefaultExpression<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        new TTypeReference Type { get; set; }
    }
}