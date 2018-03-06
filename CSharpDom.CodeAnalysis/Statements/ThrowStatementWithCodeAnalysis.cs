using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ThrowStatementWithCodeAnalysis :
        EditableThrowStatement<IExpressionWithCodeAnalysis>,
        IHasSyntax<ThrowStatementSyntax>,
        IHasNode<ThrowStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ThrowStatementWithCodeAnalysis, ThrowStatementSyntax> node;
        private readonly CachedExpressionNode<ThrowStatementWithCodeAnalysis, ThrowStatementSyntax> expression;

        public ThrowStatementWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.ThrowStatement(expression.Syntax);
        }

        internal ThrowStatementWithCodeAnalysis()
        {
            node = new StatementNode<ThrowStatementWithCodeAnalysis, ThrowStatementSyntax>(this);
            expression = new CachedExpressionNode<ThrowStatementWithCodeAnalysis, ThrowStatementSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }
        
        public ThrowStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ThrowStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<ThrowStatementSyntax> IHasNode<ThrowStatementSyntax>.Node => node;
    }
}
