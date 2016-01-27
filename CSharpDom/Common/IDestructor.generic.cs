namespace CSharpDom.Common
{
    public interface IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        IDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClass
        where TMethodBody : IMethodBody
    {
    }
}
