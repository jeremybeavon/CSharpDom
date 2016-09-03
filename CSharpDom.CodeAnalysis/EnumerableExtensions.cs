using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class EnumerableExtensions
    {
        public static SeparatedSyntaxList<TSyntax> ToSeparatedSyntaxList<T, TSyntax>(this IEnumerable<T> collection)
            where T : IHasSyntax<TSyntax>
            where TSyntax : SyntaxNode
        {
            return SyntaxFactory.SeparatedList(collection.Select(item => item.Syntax));
        }
    }
}
