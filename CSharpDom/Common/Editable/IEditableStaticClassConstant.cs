namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassConstant :
        IEditableStaticClassMember,
        IEditableConstantGroup,
        IHasEditableStaticClassMemberVisibilityModifier,
        IStaticClassConstant
    {
    }
}