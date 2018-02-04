namespace CSharpDom.Common.Editable
{
    public interface IEditableStructAccessor<TAttributeGroup, TMethodBody> :
        IEditableStructAccessor,
        IEditableAccessor<TAttributeGroup, TMethodBody>,
        IHasEditableStructAccessorVisibilityModifier,
        IStructAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
    }
}