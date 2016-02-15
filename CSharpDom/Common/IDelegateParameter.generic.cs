namespace CSharpDom.Common
{
    public interface IDelegateParameter<TAttributeGroup, TTypeReference> :
        IDelegateParameter,
        IParameter<TAttributeGroup, TTypeReference>,
        IHasModifier<ParameterModifier>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
