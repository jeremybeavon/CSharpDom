using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableGenericMemberExpression<TExpression, TTypeReference> :
        IEditableGenericMemberExpression,
        IHasEditableGenericParameters<TTypeReference>,
        IGenericMemberExpression<TExpression, TTypeReference>
        where TExpression : IEditableExpression
        where TTypeReference : IEditableTypeReference
    {
        new TExpression ObjectExpression { get; set; }

        new string MemberName { get; set; }
    }
}
