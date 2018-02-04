using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class LockStatementWithCodeAnalysis :
        EditableLockStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<LockStatementSyntax>,
        IHasNode<LockStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax> node;
        private readonly CachedExpressionNode<LockStatementWithCodeAnalysis, LockStatementSyntax> expression;
        private readonly CachedStatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax> statement;

        public LockStatementWithCodeAnalysis(
            IExpressionWithCodeAnalysis expression,
            IStatementWithCodeAnalysis statement)
            : this()
        {
            Syntax = SyntaxFactory.LockStatement(expression.Syntax, statement.Syntax);
        }

        internal LockStatementWithCodeAnalysis()
        {
            node = new StatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax>(this);
            expression = new CachedExpressionNode<LockStatementWithCodeAnalysis, LockStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            statement = new CachedStatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax>(
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

        public LockStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (LockStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<LockStatementSyntax> IHasNode<LockStatementSyntax>.Node => node;
    }
}
