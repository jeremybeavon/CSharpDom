namespace CSharpDom.Common
{
    public interface INestedDestructor<TAttributeGroup, TDeclaringType> :
        INestedDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedClass
    {
    }
}
