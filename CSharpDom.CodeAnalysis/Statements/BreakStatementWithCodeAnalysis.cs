using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class BreakStatementWithCodeAnalysis :
        EditableBreakStatement,
        IHasSyntax<BreakStatementSyntax>,
        IInternalStatement
    {
        private readonly Node<BreakStatementWithCodeAnalysis, BreakStatementSyntax> node;

        public BreakStatementWithCodeAnalysis()
        {
            node = new Node<BreakStatementWithCodeAnalysis, BreakStatementSyntax>(this);
        }

        public BreakStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        void IInternalStatement.SetParentNode<TParentNode, TParentSyntax>(TParentNode parent, Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            throw new NotImplementedException();
        }

        void IInternalStatement.SetParentNode<TParentNode, TParentSyntax>(TParentNode parent, Func<TParentSyntax, StatementSyntax> getChildSyntax, Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
        {
            throw new NotImplementedException();
        }
    }
}
