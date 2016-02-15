namespace CSharpDom.Common
{
    public interface IAsyncVoidClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> : 
        IAsyncVoidClassMethod,
        IAsyncVoidMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>,
        IHasClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
    }
}
