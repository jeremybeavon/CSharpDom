namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExtensionParameter<TExtensionParameter> : IHasExtensionParameter<TExtensionParameter>
    {
        new TExtensionParameter ExtensionParameter { get; set; }
    }
}