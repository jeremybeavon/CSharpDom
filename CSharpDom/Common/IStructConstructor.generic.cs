namespace CSharpDom.Common
{
    public interface IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IStructConstructor,
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
