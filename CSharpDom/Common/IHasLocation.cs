namespace CSharpDom.Common
{
    public interface IHasLocation
    {
        int StartLine { get; }

        int EndLine { get; }
    }
}
