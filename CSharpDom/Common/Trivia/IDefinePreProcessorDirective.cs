namespace CSharpDom.Common.Trivia
{
    public interface IDefinePreProcessorDirective : IPrePrecessorDirective
    {
        string Identifier { get; }
    }
}
