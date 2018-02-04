namespace CSharpDom.Common.Editable
{
    public interface IHasEditableTaskGenericParameter<TTypeReference> : IHasTaskGenericParameter<TTypeReference>
    {
        new TTypeReference TaskGenericParameter { get; set; }
    }
}