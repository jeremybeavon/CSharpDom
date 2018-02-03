using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QuerySelectExpressionWithCodeAnalysis : 
        EditableQuerySelectExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<SelectClauseSyntax>,
        IHasNode<SelectClauseSyntax>,
        IInternalQueryEndExpression
    {
        private readonly QueryEndExpressionNode<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax> node;
        private readonly CachedExpressionNode<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax> expression;

        internal QuerySelectExpressionWithCodeAnalysis()
        {
            node = new QueryEndExpressionNode<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax>(this);
            expression = new CachedExpressionNode<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
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
