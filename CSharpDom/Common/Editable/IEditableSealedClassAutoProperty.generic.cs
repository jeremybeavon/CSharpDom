using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        IEditableSealedClassProperty,
        IHasEditableSealedClassMemberInheritanceModifier,
        IEditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableClassAccessor
        where TExpression : IEditableExpression
    {
    }
}
