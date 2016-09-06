namespace CSharpDom.Common
{
    public interface IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        IDelegateType,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasReturnType<TTypeReference>,
        IHasParameters<TParameter>,
        IVisitable<IGenericVisitor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
    }
}
