namespace CSharpDom.Common
{
    public interface IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        IDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TMethodBody : IMethodBody
    {
    }
}
