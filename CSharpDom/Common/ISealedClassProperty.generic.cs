namespace CSharpDom.Common
{
    public interface ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        ISealedClassProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : ISealedClassAccessor
    {
    }
}
