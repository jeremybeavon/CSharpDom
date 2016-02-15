namespace CSharpDom.Common
{
    public interface IAsyncVoidExplicitInterfaceMethod<
        TAttributeGroup,
        TDeclaringType,
        TInterfaceReference,
        TGenericParameter,
        TParameter,
        TMethodBody> :
        IAsyncVoidExplicitInterfaceMethod,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IHasExplicitInterface<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
