using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using CSharpDom.Wrappers.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForStatementWithCodeAnalysis :
        EditableForStatement<IExpressionWithCodeAnalysis, IForInitializerStatementWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<ForStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax> node;
        private readonly CachedExpressionNode<ForStatementWithCodeAnalysis, ForStatementSyntax> condition;
        private readonly ExpressionListWrapper<ForStatementWithCodeAnalysis, ForStatementSyntax> incrementExpressions;
        private readonly CachedStatementNode<ForStatementWithCodeAnalysis, ForStatementSyntax> statement;

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override ICollection<IExpressionWithCodeAnalysis> IncrementExpressions
        {
            get { return incrementExpressions; }
            set { incrementExpressions.ReplaceList(value); }
        }

        public override IForInitializerStatementWithCodeAnalysis InitialValueStatement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public ForStatementSyntax Syntax
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
            set { Syntax = (ForStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
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
