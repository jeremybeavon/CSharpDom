namespace CSharpDom.Common
{
    public interface IHasPartialClassCollection<TPartialClassCollection>
    {
        TPartialClassCollection PartialClasses { get; }
    }
}
