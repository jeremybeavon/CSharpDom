using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class BinaryOperatorExpressionWithCodeAnalysis :
        EditableBinaryOperatorExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<BinaryExpressionSyntax>,
        IInternalExpression
    {
        private static readonly Map<BinaryOperatorExpressionType, SyntaxKind> operatorMap =
            new Map<BinaryOperatorExpressionType, SyntaxKind>()
            {
                { BinaryOperatorExpressionType.Add, SyntaxKind.PlusToken },
                { BinaryOperatorExpressionType.AddAssign, SyntaxKind.PlusEqualsToken },
                { BinaryOperatorExpressionType.Assign, SyntaxKind.EqualsToken },
                { BinaryOperatorExpressionType.BitwiseAnd, SyntaxKind.AmpersandToken },
                { BinaryOperatorExpressionType.BitwiseAndAssign, SyntaxKind.AmpersandEqualsToken },
                { BinaryOperatorExpressionType.BitwiseExclusiveOr, SyntaxKind.CaretToken },
                { BinaryOperatorExpressionType.BitwiseExclusiveOrAssign, SyntaxKind.CaretEqualsToken },
                { BinaryOperatorExpressionType.BitwiseOr, SyntaxKind.BarToken },
                { BinaryOperatorExpressionType.BitwiseOrAssign, SyntaxKind.BarEqualsToken },
                { BinaryOperatorExpressionType.Coalesce, SyntaxKind.QuestionQuestionToken },
                { BinaryOperatorExpressionType.Divide, SyntaxKind.SlashToken },
                { BinaryOperatorExpressionType.DivideAssign, SyntaxKind.SlashEqualsToken },
                { BinaryOperatorExpressionType.Equal, SyntaxKind.EqualsEqualsToken },
                { BinaryOperatorExpressionType.GreaterThan, SyntaxKind.GreaterThanToken },
                { BinaryOperatorExpressionType.GreaterThanOrEqual, SyntaxKind.GreaterThanEqualsToken },
                { BinaryOperatorExpressionType.LeftShift, SyntaxKind.LessThanLessThanToken },
                { BinaryOperatorExpressionType.LeftShiftAssign, SyntaxKind.LessThanLessThanEqualsToken },
                { BinaryOperatorExpressionType.LessThan, SyntaxKind.LessThanToken },
                { BinaryOperatorExpressionType.LessThanOrEqual, SyntaxKind.LessThanEqualsToken },
                { BinaryOperatorExpressionType.LogicalAnd, SyntaxKind.AmpersandAmpersandToken },
                { BinaryOperatorExpressionType.LogicalOr, SyntaxKind.BarBarToken },
                { BinaryOperatorExpressionType.Modulo, SyntaxKind.PercentToken },
                { BinaryOperatorExpressionType.ModuloAssign, SyntaxKind.PercentEqualsToken },
                { BinaryOperatorExpressionType.Multiply, SyntaxKind.AsteriskToken },
                { BinaryOperatorExpressionType.MultiplyAssign, SyntaxKind.AsteriskEqualsToken },
                { BinaryOperatorExpressionType.NotEqual, SyntaxKind.ExclamationEqualsToken },
                { BinaryOperatorExpressionType.RightShift, SyntaxKind.GreaterThanGreaterThanToken },
                { BinaryOperatorExpressionType.RightShiftAssign, SyntaxKind.GreaterThanGreaterThanEqualsToken },
                { BinaryOperatorExpressionType.Subtract, SyntaxKind.MinusToken },
                { BinaryOperatorExpressionType.SubtractAssign, SyntaxKind.MinusEqualsToken },
                { BinaryOperatorExpressionType.TypeAs, SyntaxKind.AsKeyword },
                { BinaryOperatorExpressionType.TypeIs, SyntaxKind.IsKeyword }
            };
        private readonly ExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, BinaryExpressionSyntax> node;
        private readonly CachedExpressionNode<
            BinaryOperatorExpressionWithCodeAnalysis,
            BinaryExpressionSyntax> left;
        private readonly CachedExpressionNode<
            BinaryOperatorExpressionWithCodeAnalysis,
            BinaryExpressionSyntax> right;

        internal BinaryOperatorExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, BinaryExpressionSyntax>(this);
            left = new CachedExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, BinaryExpressionSyntax>(
                node,
                syntax => syntax.Left,
                (parentSyntax, childSyntax) => parentSyntax.WithLeft(childSyntax));
            right = new CachedExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, BinaryExpressionSyntax>(
                node,
                syntax => syntax.Right,
                (parentSyntax, childSyntax) => parentSyntax.WithRight(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Left
        {
            get { return left.Value; }
            set { left.Value = value; }
        }

        public override BinaryOperatorExpressionType OperatorType
        {
            get { return operatorMap[Syntax.OperatorToken.Kind()]; }
            set { Syntax = Syntax.WithOperatorToken(SyntaxFactory.Token(operatorMap[value])); }
        }

        public override IExpressionWithCodeAnalysis Right
        {
            get { return right.Value; }
            set { right.Value = value; }
        }

        public BinaryExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (BinaryExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;
    }
}
