namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassAutoProperty :
        IEditableStaticClassMember,
        IEditableAutoProperty,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassAutoProperty
    {
    }
}
