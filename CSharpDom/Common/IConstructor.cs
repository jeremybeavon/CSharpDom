namespace CSharpDom.Common
{
    public interface IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasParameters<TParameter>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
