namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractAccessor<TAttributeGroup> :
        IEditableAbstractAccessor,
        IEditableAccessor<TAttributeGroup>,
        IAbstractAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
    }
}