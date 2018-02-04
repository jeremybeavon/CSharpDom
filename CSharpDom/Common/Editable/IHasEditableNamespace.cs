namespace CSharpDom.Common.Editable
{
    public interface IHasEditableNamespace<TNamespace> : IHasNamespace<TNamespace>
    {
        new TNamespace Namespace { get; set; }
    }
}