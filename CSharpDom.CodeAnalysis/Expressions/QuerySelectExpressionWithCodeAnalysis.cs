using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QuerySelectExpressionWithCodeAnalysis : 
        EditableQuerySelectExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<SelectClauseSyntax>
    {
        private readonly Node<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax> node;
        private readonly CachedExpressionNode<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax> expression;

        internal QuerySelectExpressionWithCodeAnalysis()
        {
            node = new Node<QuerySelectExpressionWithCodeAnalysis, SelectClauseSyntax>(this);
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
    }
}
