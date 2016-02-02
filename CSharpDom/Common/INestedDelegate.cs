namespace CSharpDom.Common
{
    public interface INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasReturnType<TTypeReference>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
    }
}
