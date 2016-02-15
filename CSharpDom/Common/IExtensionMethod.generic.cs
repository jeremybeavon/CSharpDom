namespace CSharpDom.Common
{
    public interface IExtensionMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TExtensionParameter,
        TParameter,
        TMethodBody> :
        IExtensionMethod,
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
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
