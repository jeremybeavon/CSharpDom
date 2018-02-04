namespace CSharpDom.Common.Editable
{
    public interface IEditableAccessor<TAttributeGroup> :
        IEditableAccessor,
        IHasEditableAttributes<TAttributeGroup>,
        IAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}