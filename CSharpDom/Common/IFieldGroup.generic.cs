namespace CSharpDom.Common
{
    public interface IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IFieldGroup,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasFieldType<TTypeReference>,
        IHasFields<TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TField : IField
    {
    }
}
