namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassMethod :
        IEditableStaticClassMember,
        IEditableMethod,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassMethod
    {
    }
}