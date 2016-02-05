namespace CSharpDom.Common
{
    public interface IAbstractAccessor<TAttributeGroup> :
        IAbstractAccessor,
        IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
    }
}
