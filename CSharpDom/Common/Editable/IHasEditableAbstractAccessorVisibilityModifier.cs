namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractAccessorVisibilityModifier : IHasAbstractAccessorVisibilityModifier
    {
        new AbstractAccessorVisibilityModifier Visibility { get; set; }
    }
}
