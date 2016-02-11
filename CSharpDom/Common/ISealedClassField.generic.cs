namespace CSharpDom.Common
{
    public interface ISealedClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        ISealedClassField,
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TField : IField
    {
    }
}
