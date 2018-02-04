namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClassAccessorVisibilityModifier : IHasClassAccessorVisibilityModifier
    {
        new ClassAccessorVisibilityModifier Visibility { get; set; }
    }
}