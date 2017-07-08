namespace CSharpDom.Common
{
    public interface IParameter<TAttributeGroup, TTypeReference> :
        IParameter,
        IHasName, 
        IHasAttributes<TAttributeGroup>,
        IHasParameterType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
