using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public static class LineHelper
    {
        public static int GetStartLine(SyntaxNode node)
        {
            IEnumerable<SyntaxTrivia?> trivia = node.GetLeadingTrivia().Cast<SyntaxTrivia?>();
            SyntaxTrivia? xmlDocumentation = trivia.FirstOrDefault(IsXmlDocumentation);
            Location location = xmlDocumentation.HasValue ? xmlDocumentation.Value.GetLocation() : node.GetLocation();
            return location.GetLineSpan().StartLinePosition.Line;
        }
        
        public static int GetEndLine(SyntaxNode node)
        {
            return node.GetLocation().GetLineSpan().EndLinePosition.Line;
        }

        private static bool IsXmlDocumentation(SyntaxTrivia? trivia)
        {
            return trivia.Value.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia;
        }
    }
}
