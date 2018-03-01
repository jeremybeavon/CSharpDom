using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        IStructAutoProperty,
        IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        IHasStructMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TAccessor : IStructAccessor
        where TExpression : IExpression
    {
    }
}
