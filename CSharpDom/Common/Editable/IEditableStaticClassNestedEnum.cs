namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedEnum :
        IEditableStaticClassMember,
        IEditableNestedEnum,
        IHasEditableClassMemberVisibilityModifier,
        IStaticClassNestedEnum
    {
    }
}