using System;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class TernaryOperatorExpressionWithCodeAnalysis :
        EditableTernaryOperatorExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ConditionalExpressionSyntax>,
        IHasNode<ConditionalExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<TernaryOperatorExpressionWithCodeAnalysis, ConditionalExpressionSyntax> node;
        private readonly CachedExpressionNode<
            TernaryOperatorExpressionWithCodeAnalysis,
            ConditionalExpressionSyntax> left;
        private readonly CachedExpressionNode<
            TernaryOperatorExpressionWithCodeAnalysis,
            ConditionalExpressionSyntax> middle;
        private readonly CachedExpressionNode<
            TernaryOperatorExpressionWithCodeAnalysis,
            ConditionalExpressionSyntax> right;

        public TernaryOperatorExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<TernaryOperatorExpressionWithCodeAnalysis, ConditionalExpressionSyntax>(this);
            left = new CachedExpressionNode<TernaryOperatorExpressionWithCodeAnalysis, ConditionalExpressionSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
            middle = new CachedExpressionNode<TernaryOperatorExpressionWithCodeAnalysis, ConditionalExpressionSyntax>(
                node,
                syntax => syntax.WhenTrue,
                (parentSyntax, childSyntax) => parentSyntax.WithWhenTrue(childSyntax));
            right = new CachedExpressionNode<TernaryOperatorExpressionWithCodeAnalysis, ConditionalExpressionSyntax>(
                node,
                syntax => syntax.WhenFalse,
                (parentSyntax, childSyntax) => parentSyntax.WithWhenFalse(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Left
        {
            get { return left.Value; }
            set { left.Value = value; }
        }

        public override IExpressionWithCodeAnalysis Middle
        {
            get { return middle.Value; }
            set { middle.Value = value; }
        }

        public override IExpressionWithCodeAnalysis Right
        {
            get { return right.Value; }
            set { right.Value = value; }
        }

        public ConditionalExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        INode<ConditionalExpressionSyntax> IHasNode<ConditionalExpressionSyntax>.Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ConditionalExpressionSyntax)value; }
        }
    }
}
