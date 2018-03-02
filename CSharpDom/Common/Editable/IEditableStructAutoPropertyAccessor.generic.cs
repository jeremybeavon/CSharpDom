namespace CSharpDom.Common.Editable
{
    public interface IEditableStructAutoPropertyAccessor<TAttributeGroup> :
        IEditableStructAutoPropertyAccessor,
        IEditableAutoPropertyAccessor<TAttributeGroup>,
        IHasEditableStructAccessorVisibilityModifier,
        IStructAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}
