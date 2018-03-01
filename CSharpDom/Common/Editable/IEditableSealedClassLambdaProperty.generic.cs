using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        IEditableSealedClassLambdaProperty,
        IHasEditableSealedClassMemberInheritanceModifier,
        IEditableLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
    }
}
