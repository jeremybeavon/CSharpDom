namespace CSharpDom.Common
{
    public interface IHasFieldCollection<TFieldCollection>
    {
        TFieldCollection Fields { get; }
    }
}
