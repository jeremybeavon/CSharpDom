namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassEventProperty :
        IEditableStaticClassMember,
        IEditableEventProperty,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassEventProperty
    {
    }
}