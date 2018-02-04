using System;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class GotoStatementWithCodeAnalysis :
        EditableGotoStatement,
        IHasSyntax<GotoStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<GotoStatementWithCodeAnalysis, GotoStatementSyntax> node;

        internal GotoStatementWithCodeAnalysis()
        {
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
