using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class WhileStatementWithCodeAnalysis :
        EditableWhileStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<WhileStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> node;
        private readonly CachedExpressionNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> condition;
        private readonly CachedStatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> statement;

        public WhileStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(this);
            statement = new CachedStatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
            condition = new CachedExpressionNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public WhileStatementSyntax Syntax
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
            set { Syntax = (WhileStatementSyntax)value; }
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
