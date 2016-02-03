namespace CSharpDom.Common.Trivia
{
    public interface IRegionPreProcessorDirective : IPrePrecessorDirective
    {
        string RegionName { get; }
    }
}
