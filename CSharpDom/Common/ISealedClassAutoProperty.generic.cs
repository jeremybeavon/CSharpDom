using CSharpDom.Common.Expressions;

namespace CSharpDom.Common
{
    public interface ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        ISealedClassAutoProperty,
        IHasSealedClassMemberInheritanceModifier,
        IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
        where TExpression : IExpression
    {
    }
}
