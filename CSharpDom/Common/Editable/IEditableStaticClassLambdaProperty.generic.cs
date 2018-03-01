using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IEditableStaticClassLambdaProperty,
        IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
    }
}
