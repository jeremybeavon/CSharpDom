namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClassMemberVisibilityModifier : IHasClassMemberVisibilityModifier
    {
        new ClassMemberVisibilityModifier Visibility { get; set; }
    }
}