namespace CSharpDom.Common
{
    public interface IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IInterfaceIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
