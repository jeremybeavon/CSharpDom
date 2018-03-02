namespace CSharpDom.Common.Editable
{
    public interface IEditableAutoPropertyAccessor<TAttributeGroup> :
        IEditableAutoPropertyAccessor,
        IEditableAccessor<TAttributeGroup>,
        IAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}
