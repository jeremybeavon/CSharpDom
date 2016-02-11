namespace CSharpDom.Common
{
    public interface IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        IExtensionMethod,
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IHasAsyncSupport,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
