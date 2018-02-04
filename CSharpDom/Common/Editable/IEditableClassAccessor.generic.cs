namespace CSharpDom.Common.Editable
{
    public interface IEditableClassAccessor<TAttributeGroup, TMethodBody> :
        IEditableClassAccessor,
        IEditableAccessor<TAttributeGroup, TMethodBody>,
        IHasEditableClassAccessorVisibilityModifier,
        IClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
    }
}