namespace CSharpDom.Common
{
    public interface IDestructor<TAttributeGroup, TDeclaringType> :
        IDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClass
    {
    }
}
