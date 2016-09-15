using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ParenthesisExpressionWithCodeAnalysis :
        EditableParenthesisExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ParenthesizedExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<ParenthesisExpressionWithCodeAnalysis, ParenthesizedExpressionSyntax> node;
        private readonly CachedExpressionNode<ParenthesisExpressionWithCodeAnalysis, ParenthesizedExpressionSyntax> expression;

        public ParenthesisExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<ParenthesisExpressionWithCodeAnalysis, ParenthesizedExpressionSyntax>(this);
            expression = new CachedExpressionNode<ParenthesisExpressionWithCodeAnalysis, ParenthesizedExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public ParenthesizedExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ParenthesizedExpressionSyntax)value; }
        }
    }
}
