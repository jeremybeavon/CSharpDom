namespace CSharpDom.Common
{
    public interface IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IClassField,
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TField : IField
    {
    }
}
