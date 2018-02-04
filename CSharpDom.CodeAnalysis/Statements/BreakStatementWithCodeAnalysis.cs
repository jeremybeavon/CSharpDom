using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class BreakStatementWithCodeAnalysis :
        EditableBreakStatement,
        IHasSyntax<BreakStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<BreakStatementWithCodeAnalysis, BreakStatementSyntax> node;

        public BreakStatementWithCodeAnalysis()
            : this(SyntaxFactory.BreakStatement())
        {
        }

        internal BreakStatementWithCodeAnalysis(BreakStatementSyntax syntax)
        {
            node = new StatementNode<BreakStatementWithCodeAnalysis, BreakStatementSyntax>(this);
            if (syntax != null)
            {
                Syntax = syntax;
            }
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
