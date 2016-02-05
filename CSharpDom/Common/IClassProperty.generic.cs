namespace CSharpDom.Common
{
    public interface IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IClassProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
    }
}
