namespace CSharpDom.Common
{
    public interface IHasExtensionParameter<TExtensionParameter>
    {
        TExtensionParameter ExtensionParameter { get; }
    }
}
