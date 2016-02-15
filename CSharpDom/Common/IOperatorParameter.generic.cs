namespace CSharpDom.Common
{
    public interface IOperatorParameter<TAttributeGroup, TTypeReference> :
        IOperatorParameter,
        IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
