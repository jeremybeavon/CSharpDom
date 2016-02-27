namespace CSharpDom.Common
{
    public interface IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> : 
        IMethod,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasReturnType<TTypeReference>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
    }
}
