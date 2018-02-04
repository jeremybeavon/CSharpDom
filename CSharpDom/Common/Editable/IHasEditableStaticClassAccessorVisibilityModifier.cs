namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStaticClassAccessorVisibilityModifier : IHasStaticClassAccessorVisibilityModifier
    {
        new StaticClassAccessorVisibilityModifier Visibility { get; set; }
    }
}