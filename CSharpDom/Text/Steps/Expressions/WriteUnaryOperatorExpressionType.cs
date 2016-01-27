using System.Collections.Generic;

namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteUnaryOperatorExpressionType : ISourceCodeBuilderStep
    {
        private static readonly IDictionary<UnaryOperatorExpressionType, string> operatorTypes =
            new Dictionary<UnaryOperatorExpressionType, string>()
            {
                { UnaryOperatorExpressionType.Plus, "+" }
            };

        public WriteUnaryOperatorExpressionType(UnaryOperatorExpressionType operatorType)
        {
            OperatorType = operatorType;
        }

        public UnaryOperatorExpressionType OperatorType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(operatorTypes[OperatorType]);
        }
    }
}
