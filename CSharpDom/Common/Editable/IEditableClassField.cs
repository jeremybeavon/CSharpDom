namespace CSharpDom.Common.Editable
{
    public interface IEditableClassField :
        IEditableClassMember,
        IEditableFieldGroup,
        IHasEditableClassFieldModifier,
        IClassField
    {
    }
}