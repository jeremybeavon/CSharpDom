using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal static class CachedNodeBuilder
    {
        public static CachedNodeBuilder<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> Create<TParentNode, TParentSyntax>(
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
        {
            return new CachedNodeBuilder<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>(
                StatementSyntaxExtensions.ToInternalStatement,
                getSyntax,
                createSyntax);
        }

        public static CachedNodeBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> Create<TParentNode, TParentSyntax>(
            Func<TParentSyntax, ExpressionSyntax> getSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
        {
            return new CachedNodeBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>(
                ExpressionSyntaxExtensions.ToInternalExpression,
                getSyntax,
                createSyntax);
        }
    }
}
