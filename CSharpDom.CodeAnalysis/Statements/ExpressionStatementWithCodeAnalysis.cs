using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ExpressionStatementWithCodeAnalysis :
        EditableExpressionStatement<IExpressionWithCodeAnalysis>,
        IHasSyntax<ExpressionStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax> node;
        private readonly CachedExpressionNode<ExpressionStatementWithCodeAnalysis, ExpressionStatementSyntax> expression;

        public ExpressionStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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
    }
}
