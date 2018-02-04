namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassEvent :
        IEditableStaticClassMember,
        IEditableEvent,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassEvent
    {
    }
}