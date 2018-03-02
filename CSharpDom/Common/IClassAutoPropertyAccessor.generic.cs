namespace CSharpDom.Common
{
    public interface IClassAutoPropertyAccessor<TAttributeGroup> :
        IClassAutoPropertyAccessor,
        IAutoPropertyAccessor<TAttributeGroup>,
        IHasClassAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
    {
    }
}
