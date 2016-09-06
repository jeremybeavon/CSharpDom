namespace CSharpDom.Common
{
    public interface INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        INestedDelegate,
        IHasDeclaringType<TDeclaringType>,
        IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
    }
}
