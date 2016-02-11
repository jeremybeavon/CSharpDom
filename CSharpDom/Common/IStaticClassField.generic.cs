namespace CSharpDom.Common
{
    public interface IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        IStaticClassField,
        IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TField : IField
    {
    }
}
