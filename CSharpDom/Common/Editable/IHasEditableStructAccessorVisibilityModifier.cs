namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructAccessorVisibilityModifier : IHasStructAccessorVisibilityModifier
    {
        new StructAccessorVisibilityModifier Visibility { get; set; }
    }
}