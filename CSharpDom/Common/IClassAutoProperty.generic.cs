using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface IClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        IClassAutoProperty,
        IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
        where TExpression : IExpression
    {
    }
}
