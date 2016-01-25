namespace CSharpDom.Common
{
    public interface IHasFieldType<TTypeReference>
    {
        TTypeReference FieldType { get; }
    }
}
