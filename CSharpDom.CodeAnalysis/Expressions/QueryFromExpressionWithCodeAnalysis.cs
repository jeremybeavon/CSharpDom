using CSharpDom.Common;
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
        IHasSyntax<FromClauseSyntax>,
        IInternalExpression,
        IInternalQueryExpression,
        IHasNode<FromClauseSyntax>
    {
        private readonly QueryFromExpressionType expressionType;
        private readonly ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax> node;
        private readonly QueryExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax> fromNode;
        private readonly CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax> expression;
        private readonly QueryExpressionList queryExpressions;
        private readonly CachedChildNode<
            QueryFromExpressionWithCodeAnalysis,
            QueryExpressionSyntax,
            QueryFromExpressionWithCodeAnalysis,
            FromClauseSyntax> fromClause;
        private readonly CachedChildNode<
            QueryFromExpressionWithCodeAnalysis,
            QueryExpressionSyntax,
            QueryIntoExpressionWithCodeAnalysis,
            QueryContinuationSyntax> intoExpression;

        internal QueryFromExpressionWithCodeAnalysis(QueryFromExpressionType expressionType)
        {
            this.expressionType = expressionType;
            if (expressionType == QueryFromExpressionType.FullQuery)
            {
                node = new ExpressionNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax>(this);
                fromClause = new CachedChildNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax, QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(
                    node,
                    () => this,
                    syntax => syntax.FromClause,
                    (parentSyntax, childSyntax) => parentSyntax.WithFromClause(childSyntax));
                intoExpression = new CachedChildNode<QueryFromExpressionWithCodeAnalysis, QueryExpressionSyntax, QueryIntoExpressionWithCodeAnalysis, QueryContinuationSyntax>(
                    node,
                    () => new QueryIntoExpressionWithCodeAnalysis(),
                    syntax => syntax.Body.Continuation,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(parentSyntax.Body.WithContinuation(childSyntax)));
                queryExpressions = new QueryExpressionList(this);
            }

            fromNode = new QueryExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(this);
            expression = new CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(
                fromNode,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override string Identifier
        {
            get { return fromNode.Syntax.Identifier.Text; }
            set
            {
                FromClauseSyntax syntax = fromNode.Syntax;
                fromNode.Syntax = syntax.WithIdentifier(SyntaxFactory.Identifier(value));
            }
        }

        public override IList<IQueryExpressionWithCodeAnalysis> QueryExpressions
        {
            get
            {
                return (IList< IQueryExpressionWithCodeAnalysis>)queryExpressions ??
                    new IQueryExpressionWithCodeAnalysis[0];
            }
            set
            {
                if (queryExpressions == null)
                {
                    throw new NotSupportedException();
                }

                queryExpressions.ReplaceList(value);
            }
        }

        public QueryExpressionSyntax Syntax
        {
            get { return node?.Syntax; }
            set
            {
                if (node == null)
                {
                    throw new NotSupportedException();
                }

                node.Syntax = value;
            }
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

        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node => fromNode;

        INode<FromClauseSyntax> IHasNode<FromClauseSyntax>.Node => fromNode;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (QueryExpressionSyntax)value; }
        }

        FromClauseSyntax IHasSyntax<FromClauseSyntax>.Syntax { get => fromNode.Syntax; set => fromNode.Syntax = value; }

        QueryClauseSyntax IHasSyntax<QueryClauseSyntax>.Syntax
        {
            get => fromNode.Syntax;
            set => fromNode.Syntax = (FromClauseSyntax)value;
        }
    }
}
