namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassAutoPropertyAccessor<TAttributeGroup> :
        IEditableStaticClassAutoPropertyAccessor,
        IEditableAccessor<TAttributeGroup>,
        IHasEditableStaticClassAccessorVisibilityModifier,
        IStaticClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}
