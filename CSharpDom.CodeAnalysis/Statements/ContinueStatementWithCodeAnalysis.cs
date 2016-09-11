using System;
using System.Collections.Generic;
using CSharpDom.Editable.Expressions;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ContinueStatementWithCodeAnalysis :
        EditableContinueStatement,
        IHasSyntax<ContinueStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<ContinueStatementWithCodeAnalysis, ContinueStatementSyntax> node;

        public ContinueStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<ContinueStatementWithCodeAnalysis, ContinueStatementSyntax>(this);
        }

        public ContinueStatementSyntax Syntax
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
            set { Syntax = (ContinueStatementSyntax)value; }
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
