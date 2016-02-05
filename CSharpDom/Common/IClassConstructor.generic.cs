namespace CSharpDom.Common
{
    public interface IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IClassConstructor,
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
