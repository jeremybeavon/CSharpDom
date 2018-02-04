namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceAccessor<TAttributeGroup> :
        IEditableAccessor<TAttributeGroup>,
        IEditableInterfaceAccessor,
        IInterfaceAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}