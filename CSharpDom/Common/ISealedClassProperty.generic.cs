namespace CSharpDom.Common
{
    public interface ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        ISealedClassProperty,
        IHasSealedClassMemberInheritanceModifier,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
    }
}
