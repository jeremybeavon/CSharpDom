namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup, TMethodBody> :
        IAccessor,
        IAccessor<TAttributeGroup>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
