namespace CSharpDom.Common
{
    public interface IParameter<TAttributeGroup, TTypeReference> :
        IParameter,
        IHasName, 
        IHasAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        TTypeReference ParameterType { get; }

        MethodParameterModifier Modifier { get; }
    }
}
