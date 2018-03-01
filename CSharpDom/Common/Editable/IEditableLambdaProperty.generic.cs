using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IEditableProperty,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditablePropertyType<TTypeReference>,
        IHasEditableLambdaExpression<TExpression>,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
    }
}
