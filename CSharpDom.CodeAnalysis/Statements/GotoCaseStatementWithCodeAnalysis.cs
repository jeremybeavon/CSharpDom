using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
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
        
        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = (GotoStatementSyntax)value; }
        }
    }
}
