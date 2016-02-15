namespace CSharpDom.Common
{
    public interface IHasTaskGenericParameter<TTypeReference>
    {
        TTypeReference TaskGenericParameter { get; }
    }
}
