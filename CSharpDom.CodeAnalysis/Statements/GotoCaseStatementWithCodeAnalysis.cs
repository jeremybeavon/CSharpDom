using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class GotoCaseStatementWithCodeAnalysis : 
        EditableGotoCaseStatement,
        IHasSyntax<GotoStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<GotoCaseStatementWithCodeAnalysis, GotoStatementSyntax> node;

        public GotoCaseStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<GotoCaseStatementWithCodeAnalysis, GotoStatementSyntax>(this);
        }

        public override string CaseName
        {
            get { return Syntax.Expression.ToString(); }
            set { Syntax = Syntax.WithExpression(SyntaxFactory.IdentifierName(value)); }
        }

        public GotoStatementSyntax Syntax
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
            get { return node.Syntax; }
            set { node.Syntax = (GotoStatementSyntax)value; }
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent, Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
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
