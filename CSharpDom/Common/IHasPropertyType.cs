namespace CSharpDom.Common
{
    public interface IHasPropertyType<TTypeReference>
    {
        TTypeReference PropertyType { get; }
    }
}
