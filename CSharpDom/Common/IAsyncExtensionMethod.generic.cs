namespace CSharpDom.Common
{
    public interface IAsyncExtensionMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TExtensionParameter,
        TParameter,
        TMethodBody> :
        IAsyncExtensionMethod,
        IAsyncMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IHasExtensionParameter<TExtensionParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticClass
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TExtensionParameter : IExtensionParameter
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
