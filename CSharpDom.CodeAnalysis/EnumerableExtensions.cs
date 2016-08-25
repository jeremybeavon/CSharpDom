using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class EnumerableExtensions
    {
        public static SyntaxList<AttributeListSyntax> ToAttributes<T>(this IEnumerable<T> collection)
            where T : IHasSyntax<AttributeListSyntax>
        {
            return SyntaxFactory.List(collection.Select(item => item.Syntax));
        }

        public static SeparatedSyntaxList<TSyntax> ToSeparatedSyntaxList<T, TSyntax>(this IEnumerable<T> collection)
            where T : IHasSyntax<TSyntax>
            where TSyntax : SyntaxNode
        {
            return new SeparatedSyntaxList<TSyntax>().AddRange(collection.Select(item => item.Syntax));
        }
    }
}
