namespace CSharpDom.Common
{
    public interface IAsyncVoidStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> : 
        IAsyncVoidStaticClassMethod,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
