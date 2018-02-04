namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStaticClassMemberVisibilityModifier : IHasStaticClassMemberVisibilityModifier
    {
        new StaticClassMemberVisibilityModifier Visibility { get; set; }
    }
}