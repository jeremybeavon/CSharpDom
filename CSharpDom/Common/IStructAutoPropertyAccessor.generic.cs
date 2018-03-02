namespace CSharpDom.Common
{
    public interface IStructAutoPropertyAccessor<TAttributeGroup> :
        IStructAutoPropertyAccessor,
        IAutoPropertyAccessor<TAttributeGroup>,
        IHasStructAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
    {
    }
}
