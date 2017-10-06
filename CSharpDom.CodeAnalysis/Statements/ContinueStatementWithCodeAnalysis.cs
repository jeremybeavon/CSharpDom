using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Expressions;
using CSharpDom.BaseClasses.Editable.Statements;
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
        
        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ContinueStatementSyntax)value; }
        }
    }
}
