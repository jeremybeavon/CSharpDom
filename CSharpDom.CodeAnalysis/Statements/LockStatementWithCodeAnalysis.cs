using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class LockStatementWithCodeAnalysis :
        EditableLockStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<LockStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax> node;
        private readonly CachedExpressionNode<LockStatementWithCodeAnalysis, LockStatementSyntax> expression;
        private readonly CachedStatementNode<LockStatementWithCodeAnalysis, LockStatementSyntax> statement;

        public LockStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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
    }
}
