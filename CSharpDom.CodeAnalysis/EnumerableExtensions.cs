using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class EnumerableExtensions
    {
        public static SyntaxList<TSyntax> ToSyntaxList<T, TSyntax>(this IEnumerable<T> collection)
            where T : IHasSyntax<TSyntax>
            where TSyntax : SyntaxNode
        {
            return new SyntaxList<TSyntax>().AddRange(collection.Select(item => item.Syntax));
        }

        public static SeparatedSyntaxList<TSyntax> ToSeparatedSyntaxList<T, TSyntax>(this IEnumerable<T> collection)
            where T : IHasSyntax<TSyntax>
            where TSyntax : SyntaxNode
        {
            return new SeparatedSyntaxList<TSyntax>().AddRange(collection.Select(item => item.Syntax));
        }
    }
}
