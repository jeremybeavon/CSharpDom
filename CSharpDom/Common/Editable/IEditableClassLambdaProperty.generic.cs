using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IEditableClassLambdaProperty,
        IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IHasEditableClassMemberInheritanceModifier,
        IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
    }
}
