﻿using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryFromExpressionWithCodeAnalysis :
        EditableQueryFromExpression<
            IExpressionWithCodeAnalysis,
            IQueryExpressionWithCodeAnalysis>,
        IHasSyntax<QueryExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax> node;
        private readonly CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax> expression;
        private readonly QueryExpressionList queryExpressions;
        private readonly CachedChildNode<
            QueryFromExpressionWithCodeAnalysis,
            QueryExpressionSyntax,
            QueryIntoExpressionWithCodeAnalysis,
            QueryContinuationSyntax> intoExpression;

        public QueryFromExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(this);
            expression = new CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(
                node,
                syntax => syntax.FromClause.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithFromClause(parentSyntax.FromClause.WithExpression(childSyntax)));
            queryExpressions = new QueryExpressionList(this);
                /*new QueryExpressionListWrapper<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(
                node,
                syntax => syntax.Body.Clauses,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(parentSyntax.Body.WithClauses(childSyntax)));*/
            intoExpression = new CachedChildNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax, QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax>(
                node,
                () => new QueryIntoExpressionWithCodeAnalysis(),
                syntax => syntax.Body.Continuation,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(parentSyntax.Body.WithContinuation(childSyntax)));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override string Identifier
        {
            get { return Syntax.FromClause.Identifier.Text; }
            set
            {
                QueryExpressionSyntax syntax = Syntax;
                Syntax = syntax.WithFromClause(syntax.FromClause.WithIdentifier(SyntaxFactory.Identifier(value)));
            }
        }

        public override IList<IQueryExpressionWithCodeAnalysis> QueryExpressions
        {
            get { return queryExpressions; }
            set { queryExpressions.ReplaceList(value); }
        }

        public QueryExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal QueryIntoExpressionWithCodeAnalysis IntoExpression
        {
            get { return intoExpression.Value; }
            set { intoExpression.Value = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (QueryExpressionSyntax)value; }
        }
    }
}
