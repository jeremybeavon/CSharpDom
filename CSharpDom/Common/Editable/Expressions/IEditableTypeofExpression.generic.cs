using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableTypeofExpression<TTypeReference> :
        IEditableTypeofExpression,
        ITypeofExpression<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        new TTypeReference Type { get; set; }
    }
}