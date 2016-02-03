namespace CSharpDom.Common.Trivia
{
    public enum SyntaxTriviaType
    {
        SingleLineComment,
        MultipleLineComment,
        XmlDocumentationComment,
        Whitespace,
        IfPreProcessorDirective,
        ElsePreProcessorDirective,
        ElseIfPreProcessorDirective,
        EndIfPreProcessorDirective,
        DefinePreProcessorDirective,
        UndefinePreProcessorDirective,
        WarningPreProcessorDirective,
        ErrorPreProcessorDirective,
        LinePreProcessorDirective,
        RegionPreProcessorDirective,
        EndRegionPreProcessorDirective,
        PragmaWarningPreProcessorDirective,
        PragmaChecksumPreProcessorDirective
    }
}
