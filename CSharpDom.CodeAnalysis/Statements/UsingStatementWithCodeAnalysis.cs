using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class UsingStatementWithCodeAnalysis :
        EditableUsingStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<UsingStatementSyntax>,
        IHasNode<UsingStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax> node;
        private readonly CachedExpressionNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax> expression;
        private readonly CachedStatementNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax> statement;

        public UsingStatementWithCodeAnalysis(
            IExpressionWithCodeAnalysis expression,
            IStatementWithCodeAnalysis statement)
            : this()
        {
            Syntax = SyntaxFactory.UsingStatement(null, expression.Syntax, statement.Syntax);
        }

        internal UsingStatementWithCodeAnalysis()
        {
            node = new StatementNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax>(this);
            expression = new CachedExpressionNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            statement = new CachedStatementNode<UsingStatementWithCodeAnalysis, UsingStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public UsingStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (UsingStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<UsingStatementSyntax> IHasNode<UsingStatementSyntax>.Node => node;
    }
}
