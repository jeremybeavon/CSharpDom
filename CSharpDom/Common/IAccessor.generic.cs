namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup> : IAccessor, IHasMemberVisibilityModifier, IHasAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
    }
}
