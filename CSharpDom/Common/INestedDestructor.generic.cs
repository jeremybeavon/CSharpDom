namespace CSharpDom.Common
{
    public interface INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        INestedDestructor,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedClass
        where TMethodBody : IMethodBody
    {
    }
}
