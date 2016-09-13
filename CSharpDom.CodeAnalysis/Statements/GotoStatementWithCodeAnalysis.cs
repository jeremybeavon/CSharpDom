using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class GotoStatementWithCodeAnalysis :
        EditableGotoStatement,
        IHasSyntax<GotoStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<GotoStatementWithCodeAnalysis, GotoStatementSyntax> node;

        public GotoStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<GotoStatementWithCodeAnalysis, GotoStatementSyntax>(this);
        }

        public override string LabelName
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

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
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
