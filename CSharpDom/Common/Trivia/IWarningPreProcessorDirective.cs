namespace CSharpDom.Common.Trivia
{
    public interface IWarningPreProcessorDirective : IPrePrecessorDirective
    {
        string Warning { get; }
    }
}
