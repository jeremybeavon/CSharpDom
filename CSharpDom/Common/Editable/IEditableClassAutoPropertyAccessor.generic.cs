namespace CSharpDom.Common.Editable
{
    public interface IEditableClassAutoPropertyAccessor<TAttributeGroup> :
        IEditableClassAutoPropertyAccessor,
        IEditableAutoPropertyAccessor<TAttributeGroup>,
        IHasEditableClassAccessorVisibilityModifier,
        IClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}
