namespace CSharpDom.Common
{
    public interface IMethodParameter<TAttributeGroup, TTypeReference> :
        IMethodParameter,
        IParameter<TAttributeGroup, TTypeReference>,
        IHasModifier<ParameterModifier>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
