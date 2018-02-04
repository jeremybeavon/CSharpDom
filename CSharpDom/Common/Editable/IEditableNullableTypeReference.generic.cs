namespace CSharpDom.Common.Editable
{
    public interface IEditableNullableTypeReference<TStructReference> :
        IEditableNullableTypeReference,
        INullableTypeReference<TStructReference>
        where TStructReference : IEditableStructReference
    {
        new TStructReference Type { get; set; }
    }
}