using System;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteConversionOperatorType : ISourceCodeBuilderStep
    {
        public WriteConversionOperatorType(ConversionOperatorType operatorType)
        {
            OperatorType = operatorType;
        }

        public ConversionOperatorType OperatorType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (OperatorType)
            {
                case ConversionOperatorType.Explicit:
                    builder.Append("explicit");
                    break;
                case ConversionOperatorType.Implicit:
                    builder.Append("implicit");
                    break;
            }
        }
    }
}
