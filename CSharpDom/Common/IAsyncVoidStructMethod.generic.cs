namespace CSharpDom.Common
{
    public interface IAsyncVoidStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> : 
        IAsyncVoidStructMethod,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
