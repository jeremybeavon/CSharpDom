using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Editable.Expressions;
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ExpressionStatementSyntax)value; }
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            node.SetStatementParentNode<TParentNode, TParentSyntax>(parent, getCollection);
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, StatementSyntax> getChildSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
        {
            node.SetStatementParentNode(parent, getChildSyntax, createChildSyntax);
        }
    }
}
