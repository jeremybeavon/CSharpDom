using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class IfStatementWithCodeAnalysis :
        EditableIfStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<IfStatementSyntax>,
        IHasNode<IfStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax> node;
        private readonly CachedExpressionNode<IfStatementWithCodeAnalysis, IfStatementSyntax> condition;
        private readonly CachedStatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax> thenStatement;
        private readonly CachedStatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax> elseStatement;

        public IfStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax>(this);
            condition = new CachedExpressionNode<IfStatementWithCodeAnalysis, IfStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
            thenStatement = new CachedStatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
            elseStatement = new CachedStatementNode<IfStatementWithCodeAnalysis, IfStatementSyntax>(
                node,
                syntax => syntax.Else.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithElse(parentSyntax.Else.WithStatement(childSyntax)));
        }

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override IStatementWithCodeAnalysis ElseStatement
        {
            get { return elseStatement.Value; }
            set { elseStatement.Value = value; }
        }

        public IfStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override IStatementWithCodeAnalysis ThenStatement
        {
            get { return thenStatement.Value; }
            set { thenStatement.Value = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (IfStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<IfStatementSyntax> IHasNode<IfStatementSyntax>.Node => node;
    }
}
