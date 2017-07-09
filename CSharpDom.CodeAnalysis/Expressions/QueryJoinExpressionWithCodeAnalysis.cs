using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryJoinExpressionWithCodeAnalysis :
        EditableQueryJoinExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<JoinClauseSyntax>,
        IInternalQueryExpression
    {
        private readonly QueryExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax> node;
        private readonly CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax> equalsExpression;
        private readonly CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax> inExpression;
        private readonly CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax> onExpression;

        public QueryJoinExpressionWithCodeAnalysis()
        {
            node = new QueryExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax>(this);
            equalsExpression = new CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax>(
                node,
                syntax => syntax.RightExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithRightExpression(childSyntax));
            inExpression = new CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax>(
                node,
                syntax => syntax.InExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithInExpression(childSyntax));
            onExpression = new CachedExpressionNode<QueryJoinExpressionWithCodeAnalysis, JoinClauseSyntax>(
                node,
                syntax => syntax.LeftExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithLeftExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis EqualsExpression
        {
            get { return equalsExpression.Value; }
            set { equalsExpression.Value = value; }
        }

        public override IExpressionWithCodeAnalysis InExpression
        {
            get { return inExpression.Value; }
            set { inExpression.Value = value; }
        }

        public override string IntoVariable
        {
            get { return Syntax.Into?.Identifier.Text; }
            set
            {
                JoinClauseSyntax syntax = Syntax;
                JoinIntoClauseSyntax intoClause =
                    syntax.Into == null ?
                    SyntaxFactory.JoinIntoClause(value) :
                    syntax.Into.WithIdentifier(SyntaxFactory.Identifier(value));
                Syntax = syntax.WithInto(intoClause);
            }
        }

        public override string JoinVariable
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override IExpressionWithCodeAnalysis OnExpression
        {
            get { return onExpression.Value; }
            set { onExpression.Value = value; }
        }

        public JoinClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node
        {
            get { return node; }
        }
    }
}
