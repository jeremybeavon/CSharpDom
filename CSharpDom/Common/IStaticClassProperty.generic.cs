namespace CSharpDom.Common
{
    public interface IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IStaticClassProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IStaticClassAccessor
    {
    }
}
