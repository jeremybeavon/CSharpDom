using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal static class InternalListWrapperBuilder
    {
        public static InternalListWrapperBuilder<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> Create<TParentNode, TParentSyntax>(
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            return new InternalListWrapperBuilder<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>(
                StatementSyntaxExtensions.ToInternalStatement,
                getCollection);
        }

        public static InternalListWrapperBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> Create<TParentNode, TParentSyntax>(
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            return new InternalListWrapperBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>(
                ExpressionSyntaxExtensions.ToInternalExpression,
                getCollection);
        }
    }
}
