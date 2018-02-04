namespace CSharpDom.Common.Editable
{
    public interface IEditableAttributeGroup<TAttribute> :
        IEditableAttributeGroup,
        IHasEditableAttributes<TAttribute>,
        IAttributeGroup<TAttribute>
        where TAttribute : IEditableAttribute
    {
    }
}