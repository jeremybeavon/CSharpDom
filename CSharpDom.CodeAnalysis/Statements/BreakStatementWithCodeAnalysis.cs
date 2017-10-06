using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class BreakStatementWithCodeAnalysis :
        EditableBreakStatement,
        IHasSyntax<BreakStatementSyntax>,
        IInternalStatement
    {
        private Guid internalId;
        private readonly StatementNode<BreakStatementWithCodeAnalysis, BreakStatementSyntax> node;

        public BreakStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<BreakStatementWithCodeAnalysis, BreakStatementSyntax>(this);
        }

        public BreakStatementSyntax Syntax
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
            set { Syntax = (BreakStatementSyntax)value; }
        }
    }
}
