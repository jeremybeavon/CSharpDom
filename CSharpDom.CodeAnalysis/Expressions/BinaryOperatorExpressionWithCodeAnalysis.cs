using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class BinaryOperatorExpressionWithCodeAnalysis :
        EditableBinaryOperatorExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ExpressionSyntax>,
        IHasSyntax<AssignmentExpressionSyntax>,
        IHasSyntax<BinaryExpressionSyntax>,
        IInternalExpression
    {
        private static readonly Map<BinaryOperatorExpressionType, SyntaxKind> operatorMap =
            new Map<BinaryOperatorExpressionType, SyntaxKind>()
            {
                { BinaryOperatorExpressionType.Add, SyntaxKind.PlusToken },
                { BinaryOperatorExpressionType.BitwiseAnd, SyntaxKind.AmpersandToken },
                { BinaryOperatorExpressionType.BitwiseExclusiveOr, SyntaxKind.CaretToken },
                { BinaryOperatorExpressionType.BitwiseOr, SyntaxKind.BarToken },
                { BinaryOperatorExpressionType.Coalesce, SyntaxKind.QuestionQuestionToken },
                { BinaryOperatorExpressionType.Divide, SyntaxKind.SlashToken },
                { BinaryOperatorExpressionType.Equal, SyntaxKind.EqualsEqualsToken },
                { BinaryOperatorExpressionType.GreaterThan, SyntaxKind.GreaterThanToken },
                { BinaryOperatorExpressionType.GreaterThanOrEqual, SyntaxKind.GreaterThanEqualsToken },
                { BinaryOperatorExpressionType.LeftShift, SyntaxKind.LessThanLessThanToken },
                { BinaryOperatorExpressionType.LessThan, SyntaxKind.LessThanToken },
                { BinaryOperatorExpressionType.LessThanOrEqual, SyntaxKind.LessThanEqualsToken },
                { BinaryOperatorExpressionType.LogicalAnd, SyntaxKind.AmpersandAmpersandToken },
                { BinaryOperatorExpressionType.LogicalOr, SyntaxKind.BarBarToken },
                { BinaryOperatorExpressionType.Modulo, SyntaxKind.PercentToken },
                { BinaryOperatorExpressionType.Multiply, SyntaxKind.AsteriskToken },
                { BinaryOperatorExpressionType.NotEqual, SyntaxKind.ExclamationEqualsToken },
                { BinaryOperatorExpressionType.RightShift, SyntaxKind.GreaterThanGreaterThanToken },
                { BinaryOperatorExpressionType.Subtract, SyntaxKind.MinusToken },
                { BinaryOperatorExpressionType.TypeAs, SyntaxKind.AsKeyword },
                { BinaryOperatorExpressionType.TypeIs, SyntaxKind.IsKeyword }
            };
        private static readonly Map<BinaryOperatorExpressionType, SyntaxKind> assignmentOperatorMap =
            new Map<BinaryOperatorExpressionType, SyntaxKind>()
            {
                { BinaryOperatorExpressionType.AddAssign, SyntaxKind.PlusEqualsToken },
                { BinaryOperatorExpressionType.Assign, SyntaxKind.EqualsToken },
                { BinaryOperatorExpressionType.BitwiseAndAssign, SyntaxKind.AmpersandEqualsToken },
                { BinaryOperatorExpressionType.BitwiseExclusiveOrAssign, SyntaxKind.CaretEqualsToken },
                { BinaryOperatorExpressionType.BitwiseOrAssign, SyntaxKind.BarEqualsToken },
                { BinaryOperatorExpressionType.DivideAssign, SyntaxKind.SlashEqualsToken },
                { BinaryOperatorExpressionType.LeftShiftAssign, SyntaxKind.LessThanLessThanEqualsToken },
                { BinaryOperatorExpressionType.ModuloAssign, SyntaxKind.PercentEqualsToken },
                { BinaryOperatorExpressionType.MultiplyAssign, SyntaxKind.AsteriskEqualsToken },
                { BinaryOperatorExpressionType.RightShiftAssign, SyntaxKind.GreaterThanGreaterThanEqualsToken },
                { BinaryOperatorExpressionType.SubtractAssign, SyntaxKind.MinusEqualsToken }
            };
        private readonly ExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax> node;
        private readonly CachedExpressionNode<
            BinaryOperatorExpressionWithCodeAnalysis,
            ExpressionSyntax> left;
        private readonly CachedExpressionNode<
            BinaryOperatorExpressionWithCodeAnalysis,
            ExpressionSyntax> right;

        public BinaryOperatorExpressionWithCodeAnalysis(
            IExpressionWithCodeAnalysis left,
            BinaryOperatorExpressionType @operator,
            IExpressionWithCodeAnalysis right)
            : this()
        {
            Syntax = operatorMap.ContainsKey(@operator) ?
                (ExpressionSyntax)SyntaxFactory.BinaryExpression(operatorMap[@operator], left.Syntax, right.Syntax) :
                SyntaxFactory.AssignmentExpression(assignmentOperatorMap[@operator], left.Syntax, right.Syntax);
        }

        internal BinaryOperatorExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax>(this);
            left = new CachedExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax>(
                node,
                syntax => (syntax as BinaryExpressionSyntax)?.Left ?? (syntax as AssignmentExpressionSyntax)?.Left,
                CreateLeftOperand);
            right = new CachedExpressionNode<BinaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax>(
                node,
                syntax => (syntax as BinaryExpressionSyntax)?.Right ?? (syntax as AssignmentExpressionSyntax)?.Right,
                CreateRightOperand);
        }

        public override IExpressionWithCodeAnalysis Left
        {
            get { return left.Value; }
            set { left.Value = value; }
        }

        public override BinaryOperatorExpressionType OperatorType
        {
            get
            {
                ExpressionSyntax syntax = Syntax;
                if (syntax is BinaryExpressionSyntax binarySyntax)
                {
                    return operatorMap[binarySyntax.OperatorToken.Kind()];
                }

                if (syntax is AssignmentExpressionSyntax assignmentSyntax)
                {
                    return assignmentOperatorMap[assignmentSyntax.OperatorToken.Kind()];
                }

                throw new NotSupportedException();
            }
            set
            {
                ExpressionSyntax syntax = Syntax;
                BinaryExpressionSyntax binaryExpressionSyntax = syntax as BinaryExpressionSyntax;
                AssignmentExpressionSyntax assignmentExpressionSyntax = syntax as AssignmentExpressionSyntax;
                bool isBinaryExpressionSyntax = binaryExpressionSyntax != null;
                if (operatorMap.ContainsKey(value))
                {
                    Syntax = isBinaryExpressionSyntax ?
                        binaryExpressionSyntax.WithOperatorToken(SyntaxFactory.Token(operatorMap[value])) :
                        SyntaxFactory.BinaryExpression(
                            operatorMap[value],
                            assignmentExpressionSyntax.Left,
                            assignmentExpressionSyntax.Right);
                }
                else
                {
                    Syntax = isBinaryExpressionSyntax ?
                        SyntaxFactory.AssignmentExpression(
                            assignmentOperatorMap[value],
                            binaryExpressionSyntax.Left,
                            binaryExpressionSyntax.Right) :
                        assignmentExpressionSyntax.WithOperatorToken(SyntaxFactory.Token(assignmentOperatorMap[value]));
                }
            }
        }

        public override IExpressionWithCodeAnalysis Right
        {
            get { return right.Value; }
            set { right.Value = value; }
        }

        public BinaryExpressionSyntax BinaryExpressionSyntax
        {
            get { return Syntax as BinaryExpressionSyntax; }
            set { Syntax = value; }
        }

        public AssignmentExpressionSyntax AssignmentExpressionSyntax
        {
            get { return Syntax as AssignmentExpressionSyntax; }
            set { Syntax = value; }
        }

        public ExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;

        AssignmentExpressionSyntax IHasSyntax<AssignmentExpressionSyntax>.Syntax
        {
            get { return AssignmentExpressionSyntax; }
            set { AssignmentExpressionSyntax = value; }
        }

        BinaryExpressionSyntax IHasSyntax<BinaryExpressionSyntax>.Syntax
        {
            get { return BinaryExpressionSyntax; }
            set { BinaryExpressionSyntax = value; }
        }

        private ExpressionSyntax CreateLeftOperand(ExpressionSyntax parentSyntax, ExpressionSyntax childSyntax)
        {
            return (ExpressionSyntax)(parentSyntax as BinaryExpressionSyntax)?.WithLeft(childSyntax) ??
                (parentSyntax as AssignmentExpressionSyntax)?.WithLeft(childSyntax);
        }

        private ExpressionSyntax CreateRightOperand(ExpressionSyntax parentSyntax, ExpressionSyntax childSyntax)
        {
            return (ExpressionSyntax)(parentSyntax as BinaryExpressionSyntax)?.WithRight(childSyntax) ??
                (parentSyntax as AssignmentExpressionSyntax)?.WithRight(childSyntax);
        }
    }
}
