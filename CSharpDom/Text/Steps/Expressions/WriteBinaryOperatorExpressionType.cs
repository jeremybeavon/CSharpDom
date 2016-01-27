using System.Collections.Generic;

namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteBinaryOperatorExpressionType : ISourceCodeBuilderStep
    {
        private static readonly IDictionary<BinaryOperatorExpressionType, string> operatorTypes =
            new Dictionary<BinaryOperatorExpressionType, string>()
            {
                { BinaryOperatorExpressionType.Assign, "=" }
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
