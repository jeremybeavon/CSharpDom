namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedDelegate :
        IEditableStaticClassMember,
        IEditableNestedDelegate,
        IHasEditableClassMemberVisibilityModifier,
        IStaticClassNestedDelegate
    {
    }
}