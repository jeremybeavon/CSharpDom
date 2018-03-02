using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        IAutoProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasInitialValue<TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAutoPropertyAccessor
        where TExpression : IExpression
    {
    }
}
