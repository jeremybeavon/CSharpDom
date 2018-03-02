namespace CSharpDom.Common
{
    public interface IStaticClassAutoPropertyAccessor<TAttributeGroup> :
        IStaticClassAutoPropertyAccessor,
        IAutoPropertyAccessor<TAttributeGroup>,
        IHasStaticClassAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
    {
    }
}
