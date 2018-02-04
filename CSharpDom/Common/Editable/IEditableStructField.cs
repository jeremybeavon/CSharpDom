namespace CSharpDom.Common.Editable
{
    public interface IEditableStructField :
        IEditableStructMember,
        IEditableFieldGroup,
        IHasEditableStructFieldModifier,
        IStructField
    {
    }
}