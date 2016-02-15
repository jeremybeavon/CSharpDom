namespace CSharpDom.Common
{
    public interface IExtensionParameter<TAttributeGroup, TTypeReference> :
        IExtensionParameter,
        IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
