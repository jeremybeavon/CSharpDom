using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class LabelStatementWithCodeAnalysis :
        EditableLabelStatement,
        IHasSyntax<LabeledStatementSyntax>,
        IHasNode<LabeledStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<LabelStatementWithCodeAnalysis, LabeledStatementSyntax> node;

        internal LabelStatementWithCodeAnalysis()
        {
            node = new StatementNode<LabelStatementWithCodeAnalysis, LabeledStatementSyntax>(this);
        }

        public override string LabelName
        {
            get => Syntax.Identifier.Text;
            set => Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value));
        }

        public LabeledStatementSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<LabeledStatementSyntax> IHasNode<LabeledStatementSyntax>.Node => node;

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node => node;

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (LabeledStatementSyntax)value;
        }
    }
}
