using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Expressions;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ContinueStatementWithCodeAnalysis :
        EditableContinueStatement,
        IHasSyntax<ContinueStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ContinueStatementWithCodeAnalysis, ContinueStatementSyntax> node;

        public ContinueStatementWithCodeAnalysis()
            : this(SyntaxFactory.ContinueStatement())
        {
        }

        internal ContinueStatementWithCodeAnalysis(ContinueStatementSyntax syntax)
        {
            node = new StatementNode<ContinueStatementWithCodeAnalysis, ContinueStatementSyntax>(this);
            if (syntax != null)
            {
                Syntax = syntax;
            }
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
