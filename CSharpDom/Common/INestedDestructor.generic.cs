namespace CSharpDom.Common
{
    public interface INestedDestructor<TAttributeGroup, TDeclaringType> :
        IDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedClass
    {
    }
}
