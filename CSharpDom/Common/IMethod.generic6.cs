namespace CSharpDom.Common
{
    public interface IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> : 
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IHasAsyncSupport,
        IHasPartialSupport,
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
