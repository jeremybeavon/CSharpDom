namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassField :
        IEditableStaticClassMember,
        IEditableFieldGroup,
        IHasEditableStaticClassMemberVisibilityModifier,
        IHasEditableStaticClassFieldModifier,
        IStaticClassField
    {
    }
}