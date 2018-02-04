using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ReturnStatementWithCodeAnalysis :
        EditableReturnStatement<IExpressionWithCodeAnalysis>,
        IHasSyntax<ReturnStatementSyntax>,
        IHasNode<ReturnStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax> node;
        private readonly CachedExpressionNode<ReturnStatementWithCodeAnalysis, ReturnStatementSyntax> expression;

        public ReturnStatementWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.ReturnStatement(expression.Syntax);
        }

        internal ReturnStatementWithCodeAnalysis()
        {
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

        INode<ReturnStatementSyntax> IHasNode<ReturnStatementSyntax>.Node => node;
    }
}
