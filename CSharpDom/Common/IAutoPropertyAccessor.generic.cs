namespace CSharpDom.Common
{
    public interface IAutoPropertyAccessor<TAttributeGroup> : IAutoPropertyAccessor, IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
    }
}
