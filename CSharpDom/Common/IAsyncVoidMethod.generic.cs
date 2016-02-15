namespace CSharpDom.Common
{
    public interface IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> : 
        IAsyncVoidMethod,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasParameters<TParameter>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
