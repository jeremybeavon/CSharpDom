namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup, TMethodBody> :
        IAccessor,
        IHasAttributes<TAttributeGroup>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
