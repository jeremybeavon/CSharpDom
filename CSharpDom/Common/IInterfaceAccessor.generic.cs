namespace CSharpDom.Common
{
    public interface IInterfaceAccessor<TAttributeGroup> : IAccessor<TAttributeGroup>, IInterfaceAccessor
        where TAttributeGroup : IAttributeGroup
    {
    }
}
