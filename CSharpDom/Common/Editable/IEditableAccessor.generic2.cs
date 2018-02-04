namespace CSharpDom.Common.Editable
{
    public interface IEditableAccessor<TAttributeGroup, TMethodBody> :
        IEditableAccessor,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableBody<TMethodBody>,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
    }
}