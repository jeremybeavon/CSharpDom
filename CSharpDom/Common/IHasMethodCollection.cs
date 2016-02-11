namespace CSharpDom.Common
{
    public interface IHasMethodCollection<TMethodCollection>
    {
        TMethodCollection Methods { get; }
    }
}
