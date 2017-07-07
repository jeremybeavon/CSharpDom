using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class BinaryOperatorExpressionWithLinqExpressions :
        AbstractBinaryOperatorExpression<ILinqExpression>,
        ILinqExpression<BinaryExpression>
    {
        private static readonly IDictionary<ExpressionType, BinaryOperatorExpressionType> expressionTypeMap =
            new Dictionary<ExpressionType, BinaryOperatorExpressionType>()
            {
                { ExpressionType.Add, BinaryOperatorExpressionType.Add },
                { ExpressionType.AddAssign, BinaryOperatorExpressionType.AddAssign },
                { ExpressionType.AddAssignChecked, BinaryOperatorExpressionType.AddAssign },
                { ExpressionType.AddChecked, BinaryOperatorExpressionType.Add },
                { ExpressionType.And, BinaryOperatorExpressionType.BitwiseAnd },
                { ExpressionType.AndAlso, BinaryOperatorExpressionType.LogicalAnd },
                { ExpressionType.AndAssign, BinaryOperatorExpressionType.BitwiseAndAssign },
                { ExpressionType.Assign, BinaryOperatorExpressionType.Assign },
                { ExpressionType.Coalesce, BinaryOperatorExpressionType.Coalesce },
                { ExpressionType.Divide, BinaryOperatorExpressionType.Divide },
                { ExpressionType.DivideAssign, BinaryOperatorExpressionType.DivideAssign },
                { ExpressionType.Equal, BinaryOperatorExpressionType.Equal },
                { ExpressionType.ExclusiveOr, BinaryOperatorExpressionType.BitwiseExclusiveOr },
                { ExpressionType.ExclusiveOrAssign, BinaryOperatorExpressionType.BitwiseExclusiveOrAssign },
                { ExpressionType.GreaterThan, BinaryOperatorExpressionType.GreaterThan },
                { ExpressionType.GreaterThanOrEqual, BinaryOperatorExpressionType.GreaterThanOrEqual },
                { ExpressionType.LeftShift, BinaryOperatorExpressionType.LeftShift },
                { ExpressionType.LeftShiftAssign, BinaryOperatorExpressionType.LeftShiftAssign },
                { ExpressionType.LessThan, BinaryOperatorExpressionType.LessThan },
                { ExpressionType.LessThanOrEqual, BinaryOperatorExpressionType.LessThanOrEqual },
                { ExpressionType.Modulo, BinaryOperatorExpressionType.Modulo },
                { ExpressionType.ModuloAssign, BinaryOperatorExpressionType.ModuloAssign },
                { ExpressionType.Multiply, BinaryOperatorExpressionType.Multiply },
                { ExpressionType.MultiplyAssign, BinaryOperatorExpressionType.MultiplyAssign },
                { ExpressionType.MultiplyAssignChecked, BinaryOperatorExpressionType.MultiplyAssign },
                { ExpressionType.MultiplyChecked, BinaryOperatorExpressionType.Multiply },
                { ExpressionType.NotEqual, BinaryOperatorExpressionType.NotEqual },
                { ExpressionType.Or, BinaryOperatorExpressionType.BitwiseOr },
                { ExpressionType.OrAssign, BinaryOperatorExpressionType.BitwiseOrAssign },
                { ExpressionType.OrElse, BinaryOperatorExpressionType.LogicalOr },
                { ExpressionType.RightShift, BinaryOperatorExpressionType.RightShift },
                { ExpressionType.RightShiftAssign, BinaryOperatorExpressionType.RightShiftAssign },
                { ExpressionType.Subtract, BinaryOperatorExpressionType.Subtract },
                { ExpressionType.SubtractAssign, BinaryOperatorExpressionType.SubtractAssign },
                { ExpressionType.SubtractAssignChecked, BinaryOperatorExpressionType.SubtractAssign },
                { ExpressionType.SubtractChecked, BinaryOperatorExpressionType.Subtract }
            };

        private readonly ILinqExpression left;
        private readonly ILinqExpression right;

        public BinaryOperatorExpressionWithLinqExpressions(BinaryExpression binaryExpression)
        {
            Expression = binaryExpression;
            left = LinqExpressionBuilder.BuildExpression(binaryExpression.Left);
            right = LinqExpressionBuilder.BuildExpression(binaryExpression.Right);
        }

        public BinaryExpression Expression { get; private set; }

        public override ILinqExpression Left
        {
            get { return left; }
        }

        public override BinaryOperatorExpressionType OperatorType
        {
            get { return expressionTypeMap[Expression.NodeType]; }
        }

        public override ILinqExpression Right
        {
            get { return right; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
