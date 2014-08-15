namespace CSharpDom.Common
{
    public interface IHasProject<TProject>
    {
        TProject Project { get; }
    }
}
