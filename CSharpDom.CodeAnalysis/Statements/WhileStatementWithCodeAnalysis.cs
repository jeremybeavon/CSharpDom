using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class WhileStatementWithCodeAnalysis :
        EditableWhileStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<WhileStatementSyntax>,
        IHasNode<WhileStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> node;
        private readonly CachedExpressionNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> condition;
        private readonly CachedStatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax> statement;

        public WhileStatementWithCodeAnalysis(
            IExpressionWithCodeAnalysis condition,
            IStatementWithCodeAnalysis statement)
            : this()
        {
            Syntax = SyntaxFactory.WhileStatement(condition.Syntax, statement.Syntax);
        }

        internal WhileStatementWithCodeAnalysis()
        {
            node = new StatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(this);
            statement = new CachedStatementNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
            condition = new CachedExpressionNode<WhileStatementWithCodeAnalysis, WhileStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public WhileStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (WhileStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<WhileStatementSyntax> IHasNode<WhileStatementSyntax>.Node => node;
    }
}
