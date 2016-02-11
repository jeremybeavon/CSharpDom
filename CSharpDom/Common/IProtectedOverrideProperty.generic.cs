namespace CSharpDom.Common
{
    public interface IProtectedOverrideProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IProtectedOverrideProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TAccessor : ISealedClassAccessor
    {
    }
}
