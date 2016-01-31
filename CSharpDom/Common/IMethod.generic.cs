namespace CSharpDom.Common
{
    public interface IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> : 
        IMethod,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasAsyncSupport,
        IHasPartialSupport,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasReturnType<TTypeReference>,
        IHasParameters<TParameter>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
