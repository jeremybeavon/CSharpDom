using System.Collections.Generic;

namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteBinaryOperatorExpressionType : ISourceCodeBuilderStep
    {
        private static readonly IDictionary<BinaryOperatorExpressionType, string> operatorTypes =
            new Dictionary<BinaryOperatorExpressionType, string>()
            {
                { BinaryOperatorExpressionType.Add, "+" },
                { BinaryOperatorExpressionType.AddAssign, "+=" },
                { BinaryOperatorExpressionType.Assign, "=" },
                { BinaryOperatorExpressionType.BitwiseAnd, "&" },
                { BinaryOperatorExpressionType.BitwiseAndAssign, "&=" },
                { BinaryOperatorExpressionType.BitwiseExclusiveOr, "^" },
                { BinaryOperatorExpressionType.BitwiseExclusiveOrAssign, "^=" },
                { BinaryOperatorExpressionType.BitwiseOr, "|" },
                { BinaryOperatorExpressionType.BitwiseOrAssign, "|=" },
                { BinaryOperatorExpressionType.Coalesce, "??" },
                { BinaryOperatorExpressionType.Divide, "/" },
                { BinaryOperatorExpressionType.DivideAssign, "/=" },
                { BinaryOperatorExpressionType.Equal, "==" },
                { BinaryOperatorExpressionType.GreaterThan, ">" },
                { BinaryOperatorExpressionType.GreaterThanOrEqual, ">=" },
                { BinaryOperatorExpressionType.LeftShift, "<<" },
                { BinaryOperatorExpressionType.LeftShiftAssign, "<<=" },
                { BinaryOperatorExpressionType.LessThan, "<" },
                { BinaryOperatorExpressionType.LessThanOrEqual, "<=" },
                { BinaryOperatorExpressionType.LogicalAnd, "&&" },
                { BinaryOperatorExpressionType.LogicalOr, "||" },
                { BinaryOperatorExpressionType.Modulo, "%" },
                { BinaryOperatorExpressionType.ModuloAssign, "%=" },
                { BinaryOperatorExpressionType.Multiply, "*" },
                { BinaryOperatorExpressionType.MultiplyAssign, "*=" },
                { BinaryOperatorExpressionType.NotEqual, "!=" },
                { BinaryOperatorExpressionType.RightShift, ">>" },
                { BinaryOperatorExpressionType.RightShiftAssign, ">>" },
                { BinaryOperatorExpressionType.Subtract, "-" },
                { BinaryOperatorExpressionType.SubtractAssign, "-=" },
                { BinaryOperatorExpressionType.TypeAs, "as" },
                { BinaryOperatorExpressionType.TypeIs, "is" }
            };

        public WriteBinaryOperatorExpressionType(BinaryOperatorExpressionType operatorType)
        {
            OperatorType = operatorType;
        }

        public BinaryOperatorExpressionType OperatorType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(operatorTypes[OperatorType]);
        }
    }
}
