namespace CSharpDom.Common
{
    public interface IAsyncVoidSealedClassMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TParameter,
        TMethodBody> : 
        IAsyncVoidSealedClassMethod,
        IHasSealedClassMemberInheritanceModifier,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
