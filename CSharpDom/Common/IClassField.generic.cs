namespace CSharpDom.Common
{
    public interface IClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IClassField,
        IField<TAttributeGroup, TDeclaringType, TTypeReference>,
        IHasClassMemberVisibilityModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
    }
}
