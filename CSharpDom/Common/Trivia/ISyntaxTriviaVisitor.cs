namespace CSharpDom.Common.Trivia
{
    public interface ISyntaxTriviaVisitor
    {
        void Visit(ISyntaxTrivia syntaxTrivia);

        void VisitSingleLineComment(IComment comment);

        void VisitMultipleLineComment(IComment comment);

        void VisitXmlDocumentationComment(IComment comment);

        void VisitWhitespace(IWhitespace whiteSpace);

        void VisitIfPreProcessorDirective<TPreProcessorExpression>(IIfPreProcessorDirective<TPreProcessorExpression> directive)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitElsePreProcessorDirective(IPrePrecessorDirective directive);

        void VisitElseIfPreProcessorDirective<TPreProcessorExpression>(IElseIfPreProcessorDirective<TPreProcessorExpression> directive)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitEndIfPreProcessorDirective(IPrePrecessorDirective directive);

        void VisitDefinePreProcessorDirective(IDefinePreProcessorDirective directive);

        void VisitUndefinePreProcessorDirective(IUndefinePreProcessorDirective directive);

        void VisitWarningPreProcessorDirective(IWarningPreProcessorDirective directive);

        void VisitErrorPreProcessorDirective(IErrorPreProcessorDirective directive);

        void VisitRegionPreProcessorDirective(IRegionPreProcessorDirective directive);

        void VisitEndRegionPreProcessorDirective(IEndRegionPreProcessorDirective directive);

        void VisitPragmaWarningPreProcessorDirective(IPrePrecessorDirective directive);

        void VisitPragmaChecksumPreProcessorDirective(IPrePrecessorDirective directive);
    }
}
