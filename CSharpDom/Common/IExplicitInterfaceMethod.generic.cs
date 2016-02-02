namespace CSharpDom.Common
{
    public interface IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        IExplicitInterfaceMethod,
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IHasExplicitInterface<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
