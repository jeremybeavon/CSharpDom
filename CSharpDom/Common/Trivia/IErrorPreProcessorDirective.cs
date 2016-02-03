namespace CSharpDom.Common.Trivia
{
    public interface IErrorPreProcessorDirective : IPrePrecessorDirective
    {
        string Error { get; }
    }
}
