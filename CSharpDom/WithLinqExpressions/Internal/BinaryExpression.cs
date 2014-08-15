using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqBinaryExpression = System.Linq.Expressions.BinaryExpression;
using LinqExpression = System.Linq.Expressions.Expression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class BinaryExpression : LinqExpressionMapping<LinqBinaryExpression, BinaryExpressionSyntax>, 
        IBinaryExpression
    {
        private static IReadOnlyDictionary<SyntaxKind, BinaryExpressionBuilder> expresionBuilders =
            new BinaryExpressionBuilderList()
        {
            { SyntaxKind.PlusToken, LinqExpression.Add, BinaryExpressionType.Add },
            { SyntaxKind.AddAssignmentExpression, LinqExpression.AddAssign, BinaryExpressionType.AddAssign },
            { SyntaxKind.EqualsToken, LinqExpression.Assign, BinaryExpressionType.Assign },
            { SyntaxKind.AmpersandToken, LinqExpression.And, BinaryExpressionType.BitwiseAnd },
            { SyntaxKind.AmpersandEqualsToken, LinqExpression.AndAssign, BinaryExpressionType.BitwiseAndAssign },
            { SyntaxKind.BarToken, LinqExpression.Or, BinaryExpressionType.BitwiseOr },
            { SyntaxKind.BarEqualsToken, LinqExpression.OrAssign, BinaryExpressionType.BitwiseOrAssign },
            { SyntaxKind.CaretToken, LinqExpression.ExclusiveOr, BinaryExpressionType.BitwiseXor },
            { SyntaxKind.CaretEqualsToken, LinqExpression.ExclusiveOrAssign, BinaryExpressionType.BitwiseXorAssign },
            { SyntaxKind.QuestionQuestionToken, LinqExpression.Coalesce, BinaryExpressionType.Coalesce },
            { SyntaxKind.SlashToken, LinqExpression.Divide, BinaryExpressionType.Divide },
            { SyntaxKind.SlashEqualsToken, LinqExpression.DivideAssign, BinaryExpressionType.DivideAssign },
            { SyntaxKind.EqualsEqualsToken, LinqExpression.Equal, BinaryExpressionType.EqualTo },
            { SyntaxKind.GreaterThanToken, LinqExpression.GreaterThan, BinaryExpressionType.GreaterThan },
            { SyntaxKind.GreaterThanEqualsToken, LinqExpression.GreaterThanOrEqual, BinaryExpressionType.GreaterThanOrEqualTo },
            { SyntaxKind.LessThanLessThanToken, LinqExpression.LeftShift, BinaryExpressionType.LeftShift },
            { SyntaxKind.LessThanLessThanEqualsToken, LinqExpression.LeftShiftAssign, BinaryExpressionType.LeftShiftAssign },
            { SyntaxKind.LessThanToken, LinqExpression.LessThan, BinaryExpressionType.LessThan },
            { SyntaxKind.LessThanEqualsToken, LinqExpression.LessThanOrEqual, BinaryExpressionType.LessThanOrEqualTo },
            { SyntaxKind.AmpersandAmpersandToken, LinqExpression.AndAlso, BinaryExpressionType.LogicalAnd },
            { SyntaxKind.BarBarToken, LinqExpression.OrElse, BinaryExpressionType.LogicalOr },
            { SyntaxKind.PercentToken, LinqExpression.Modulo, BinaryExpressionType.Modulo },
            { SyntaxKind.PercentEqualsToken, LinqExpression.ModuloAssign, BinaryExpressionType.ModuloAssign },
            { SyntaxKind.AsteriskToken, LinqExpression.Multiply, BinaryExpressionType.Multiply },
            { SyntaxKind.AsteriskEqualsToken, LinqExpression.MultiplyAssign, BinaryExpressionType.MultiplyAssign },
            { SyntaxKind.ExclamationEqualsToken, LinqExpression.NotEqual, BinaryExpressionType.NotEqualTo },
            { SyntaxKind.GreaterThanGreaterThanToken, LinqExpression.RightShift, BinaryExpressionType.RightShift },
            { SyntaxKind.GreaterThanGreaterThanEqualsToken, LinqExpression.RightShiftAssign, BinaryExpressionType.RightShiftAssign },
            { SyntaxKind.MinusToken, LinqExpression.Subtract, BinaryExpressionType.Subtract },
            { SyntaxKind.MinusEqualsToken, LinqExpression.SubtractAssign, BinaryExpressionType.SubtractAssign }
        };

        internal BinaryExpression(
            ILinqExpressionMapping left,
            ILinqExpressionMapping right,
            BinaryExpressionSyntax syntax)
            : this(left, right, expresionBuilders[syntax.OperatorToken.CSharpKind()], syntax)
        {
        }

        private BinaryExpression(
            ILinqExpressionMapping left,
            ILinqExpressionMapping right,
            BinaryExpressionBuilder builder,
            BinaryExpressionSyntax syntax)
            : base(builder.LinqExpressionBuilder(left.Expression, right.Expression), syntax)
        {
            Left = left;
            Right = right;
            ExpressionType = builder.ExpressionType;
        }

        public ILinqExpressionMapping Left { get; private set; }

        public ILinqExpressionMapping Right { get; private set; }

        public BinaryExpressionType ExpressionType { get; internal set; }
    }
}
