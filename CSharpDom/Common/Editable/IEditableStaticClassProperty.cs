namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassProperty :
        IEditableStaticClassMember,
        IEditableProperty,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassProperty
    {
    }
}