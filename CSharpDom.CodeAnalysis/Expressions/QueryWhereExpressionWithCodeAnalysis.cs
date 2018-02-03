using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryWhereExpressionWithCodeAnalysis :
        EditableQueryWhereExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<WhereClauseSyntax>,
        IHasNode<WhereClauseSyntax>,
        IInternalQueryExpression
    {
        private readonly QueryExpressionNode<QueryWhereExpressionWithCodeAnalysis, WhereClauseSyntax> node;
        private readonly CachedExpressionNode<QueryWhereExpressionWithCodeAnalysis, WhereClauseSyntax> expression;

        public QueryWhereExpressionWithCodeAnalysis()
        {
            node = new QueryExpressionNode<QueryWhereExpressionWithCodeAnalysis, WhereClauseSyntax>(this);
            expression = new CachedExpressionNode<QueryWhereExpressionWithCodeAnalysis, WhereClauseSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public WhereClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node
        {
            get { return node; }
        }

        INode<WhereClauseSyntax> IHasNode<WhereClauseSyntax>.Node => node;
    }
}
