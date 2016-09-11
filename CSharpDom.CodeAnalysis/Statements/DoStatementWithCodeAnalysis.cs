using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class DoStatementWithCodeAnalysis :
        EditableDoStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<DoStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax> node;
        private readonly CachedExpressionNode<DoStatementWithCodeAnalysis, DoStatementSyntax> condition;
        private readonly CachedStatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax> statement;

        public DoStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(this);
            condition = new CachedExpressionNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
            statement = new CachedStatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
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

        public DoStatementSyntax Syntax
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
            set { Syntax = (DoStatementSyntax)value; }
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
