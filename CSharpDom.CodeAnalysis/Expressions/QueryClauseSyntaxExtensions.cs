using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal static class QueryClauseSyntaxExtensions
    {
        private static IDictionary<Type, Func<IInternalQueryExpression>> queryClauseMap =
            new Dictionary<Type, Func<IInternalQueryExpression>>()
            {
                { typeof(FromClauseSyntax), () => new QueryFromExpressionWithCodeAnalysis(QueryFromExpressionType.OnlyFromExpression) },
                { typeof(JoinClauseSyntax), () => new QueryJoinExpressionWithCodeAnalysis() },
                { typeof(LetClauseSyntax), () => new QueryLetExpressionWithCodeAnalysis() },
                { typeof(OrderByClauseSyntax), () => new QueryOrderByExpressionWithCodeAnalysis() },
                { typeof(WhereClauseSyntax), () => new QueryWhereExpressionWithCodeAnalysis() },
            };

        public static IInternalQueryExpression ToInternalQueryExpression(this QueryClauseSyntax syntax)
        {
            return null;
        }
    }
}
