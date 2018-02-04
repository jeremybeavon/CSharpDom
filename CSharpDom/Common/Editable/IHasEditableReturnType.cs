namespace CSharpDom.Common.Editable
{
    public interface IHasEditableReturnType<TTypeReference> : IHasReturnType<TTypeReference>
    {
        new TTypeReference ReturnType { get; set; }
    }
}