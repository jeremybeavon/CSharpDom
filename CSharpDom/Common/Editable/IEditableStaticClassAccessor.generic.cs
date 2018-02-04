namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassAccessor<TAttributeGroup, TMethodBody> :
        IEditableStaticClassAccessor,
        IEditableAccessor<TAttributeGroup, TMethodBody>,
        IHasEditableStaticClassAccessorVisibilityModifier,
        IStaticClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
    }
}