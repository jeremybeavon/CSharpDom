using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal static class EnumerableExtensions
    {
        public static ArgumentListSyntax ToArgumentList(this IEnumerable<IExpressionWithCodeAnalysis> collection)
        {
            return SyntaxFactory.ArgumentList(
                SyntaxFactory.SeparatedList(collection.Select(item => SyntaxFactory.Argument(item.Syntax))));
        }
    }
}
