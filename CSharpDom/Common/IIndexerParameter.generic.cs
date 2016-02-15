namespace CSharpDom.Common
{
    public interface IIndexerParameter<TAttributeGroup, TTypeReference> :
        IIndexerParameter,
        IParameter<TAttributeGroup, TTypeReference>,
        IHasModifier<IndexerParameterModifier>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
    }
}
