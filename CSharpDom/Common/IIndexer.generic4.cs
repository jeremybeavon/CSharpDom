namespace CSharpDom.Common
{
    public interface IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasIndexerType<TTypeReference>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
    }
}
