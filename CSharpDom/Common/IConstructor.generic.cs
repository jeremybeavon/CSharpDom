namespace CSharpDom.Common
{
    public interface IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IConstructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasParameters<TParameter>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
    }
}
