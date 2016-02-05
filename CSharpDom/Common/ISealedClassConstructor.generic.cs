namespace CSharpDom.Common
{
    public interface ISealedClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        ISealedClassConstructor,
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
    }
}
