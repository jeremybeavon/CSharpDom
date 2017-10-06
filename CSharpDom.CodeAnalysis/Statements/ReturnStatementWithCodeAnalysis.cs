using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ReturnStatementWithCodeAnalysis :
        EditableReturnStatement<IExpressionWithCodeAnalysis>,
        IHasSyntax<ReturnStatementSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax> node;
        private readonly CachedExpressionNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax> expression;

        public ReturnStatementWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new StatementNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax>(this);
            expression = new CachedExpressionNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public ReturnStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ReturnStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }
    }
}
