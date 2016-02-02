namespace CSharpDom.Common
{
    public interface IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IInterfaceMethod,
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
    }
}
