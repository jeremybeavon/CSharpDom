using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AwaitExpressionWithCodeAnalysis :
        EditableAwaitExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<AwaitExpressionSyntax>,
        IHasNode<AwaitExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax> node;
        private readonly CachedExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax> expression;

        public AwaitExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax>(this);
            expression = new CachedExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public AwaitExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (AwaitExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<AwaitExpressionSyntax> IHasNode<AwaitExpressionSyntax>.Node => node;
    }
}
