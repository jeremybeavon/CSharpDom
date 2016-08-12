namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup> : IAccessor, IHasAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
    }
}
