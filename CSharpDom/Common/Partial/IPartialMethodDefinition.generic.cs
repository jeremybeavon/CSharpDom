namespace CSharpDom.Common.Partial
{
    public interface IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> : 
        IPartialMethodDefinition,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasReturnAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
    {
    }
}
