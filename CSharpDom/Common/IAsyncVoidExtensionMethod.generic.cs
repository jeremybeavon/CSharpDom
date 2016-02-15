namespace CSharpDom.Common
{
    public interface IAsyncVoidExtensionMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TExtensionParameter,
        TParameter,
        TMethodBody> :
        IAsyncVoidExtensionMethod,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IHasExtensionParameter<TExtensionParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticClass
        where TGenericParameter : IGenericParameterDeclaration
        where TExtensionParameter : IExtensionParameter
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
