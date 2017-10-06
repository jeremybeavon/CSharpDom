using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryFromExpressionWithCodeAnalysis :
        EditableQueryFromExpression<
            IExpressionWithCodeAnalysis>,
        IHasSyntax<FromClauseSyntax>,
        IHasNode<FromClauseSyntax>,
        IInternalQueryExpression
    {
        private readonly QueryExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax> node;
        private readonly CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax> expression;
        
        internal QueryFromExpressionWithCodeAnalysis()
        {
            node = new QueryExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(this);
            expression = new CachedExpressionNode<QueryFromExpressionWithCodeAnalysis, FromClauseSyntax>(
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
            get { return Syntax.Identifier.Text; }
            set
            {
                FromClauseSyntax syntax = Syntax;
                Syntax = syntax.WithIdentifier(SyntaxFactory.Identifier(value));
            }
        }
        
        public FromClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<QueryClauseSyntax> IHasNode<QueryClauseSyntax>.Node => node;

        INode<FromClauseSyntax> IHasNode<FromClauseSyntax>.Node => node;
    }
}
