using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QuerySelectIntoExpressionWithCodeAnalysis : 
        EditableQuerySelectIntoExpression<IExpressionWithCodeAnalysis, QueryIntoExpressionWithCodeAnalysis>,
        IHasSyntax<SelectClauseSyntax>,
        IHasNode<SelectClauseSyntax>,
        IInternalQueryEndExpression
    {
        private readonly QueryEndExpressionNode<QuerySelectIntoExpressionWithCodeAnalysis, SelectClauseSyntax> node;
        private readonly CachedExpressionNode<QuerySelectIntoExpressionWithCodeAnalysis, SelectClauseSyntax> expression;

        internal QuerySelectIntoExpressionWithCodeAnalysis()
        {
            node = new QueryEndExpressionNode<QuerySelectIntoExpressionWithCodeAnalysis, SelectClauseSyntax>(this);
            expression = new CachedExpressionNode<QuerySelectIntoExpressionWithCodeAnalysis, SelectClauseSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override QueryIntoExpressionWithCodeAnalysis IntoExpression
        {
            get { return node.GetParentNode<QueryBodyWithCodeAnalysis>().IntoExpression; }
            set { node.GetParentNode<QueryBodyWithCodeAnalysis>().IntoExpression = value; }
        }

        public SelectClauseSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        SelectOrGroupClauseSyntax IHasSyntax<SelectOrGroupClauseSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (SelectClauseSyntax)value;
        }

        INode<SelectOrGroupClauseSyntax> IHasNode<SelectOrGroupClauseSyntax>.Node => node;

        INode<SelectClauseSyntax> IHasNode<SelectClauseSyntax>.Node => node;
    }
}
