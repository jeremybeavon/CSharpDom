using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IEditableStructLambdaProperty,
        IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IHasEditableStructMemberInheritanceModifier,
        IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
    }
}
