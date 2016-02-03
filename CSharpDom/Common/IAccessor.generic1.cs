namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup> : IHasAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
    }
}
