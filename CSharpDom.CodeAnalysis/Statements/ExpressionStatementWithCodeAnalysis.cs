using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ExpressionStatementWithCodeAnalysis :
        EditableExpressionStatement<IExpressionWithCodeAnalysis>,
        IHasSyntax<ExpressionStatementSyntax>,
        IHasNode<ExpressionStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax> node;
        private readonly CachedExpressionNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax> expression;

        public ExpressionStatementWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.ExpressionStatement(expression.Syntax);
        }

        internal ExpressionStatementWithCodeAnalysis()
        {
            node = new StatementNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax>(this);
            expression = new CachedExpressionNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public ExpressionStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ExpressionStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<ExpressionStatementSyntax> IHasNode<ExpressionStatementSyntax>.Node => node;
    }
}
