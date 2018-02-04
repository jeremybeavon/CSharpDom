namespace CSharpDom.Common.Editable
{
    public interface IHasEditableTypeVisibilityModifier : IHasTypeVisibilityModifier
    {
        new TypeVisibilityModifier Visibility { get; set; }
    }
}