using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal static class LiteralExpressionSyntaxExtensions
    {
        public static LiteralExpressionSyntax WithToken(
            this LiteralExpressionSyntax syntax,
            string text,
            string valueText)
        {
            SyntaxToken token = syntax.Token;
            return syntax.WithToken(
                SyntaxFactory.Token(token.LeadingTrivia, token.Kind(), text, valueText, token.TrailingTrivia));
        }
    }
}
