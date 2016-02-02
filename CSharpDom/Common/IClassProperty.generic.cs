namespace CSharpDom.Common
{
    public interface IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IClassProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
    }
}
