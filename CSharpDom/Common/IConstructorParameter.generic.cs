namespace CSharpDom.Common
{
    public interface IConstructorParameter<TAttributeGroup, TTypeReference> :
        IConstructorParameter,
        IParameter<TAttributeGroup, TTypeReference>,
        IHasModifier<ParameterModifier>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
