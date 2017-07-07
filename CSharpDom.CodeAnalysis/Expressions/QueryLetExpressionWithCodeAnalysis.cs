using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryLetExpressionWithCodeAnalysis :
        EditableQueryLetExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<LetClauseSyntax>,
        IInternalQueryExpression
    {
        private readonly QueryExpressionNode<QueryLetExpressionWithCodeAnalysis, LetClauseSyntax> node;
        private readonly CachedExpressionNode<QueryLetExpressionWithCodeAnalysis, LetClauseSyntax> expression;

        internal QueryLetExpressionWithCodeAnalysis()
        {
            node = new QueryExpressionNode<QueryLetExpressionWithCodeAnalysis, LetClauseSyntax>(this);
            expression = new CachedExpressionNode<QueryLetExpressionWithCodeAnalysis, LetClauseSyntax>(
                node,
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
            get { return node.Syntax.Identifier.Text; }
            set { node.Syntax = node.Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public LetClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        QueryClauseSyntax IHasSyntax<QueryClauseSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (LetClauseSyntax)value; }
        }

        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node => node;
    }
}
