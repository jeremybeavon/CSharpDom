using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteOperatorOverloadType : ISourceCodeBuilderStep
    {
        private static readonly IDictionary<OperatorOverloadType, string> operatorTypes =
            new Dictionary<OperatorOverloadType, string>()
            {
                { OperatorOverloadType.And, "&" },
                { OperatorOverloadType.BitwiseNot, "~" },
                { OperatorOverloadType.Decrement, "--" },
                { OperatorOverloadType.Divide, "/" },
                { OperatorOverloadType.Equal, "==" },
                { OperatorOverloadType.ExclusiveOr, "^" },
                { OperatorOverloadType.False, "false" },
                { OperatorOverloadType.GreaterThan, ">" },
                { OperatorOverloadType.GreaterThanOrEqual, ">=" },
                { OperatorOverloadType.Increment, "++" },
                { OperatorOverloadType.LeftShift, "<<" },
                { OperatorOverloadType.LessThan, "<" },
                { OperatorOverloadType.LessThanOrEqual, "<=" },
                { OperatorOverloadType.LogicalNot, "!" },
                { OperatorOverloadType.Minus, "-" },
                { OperatorOverloadType.Modulo, "%" },
                { OperatorOverloadType.Multiply, "*" },
                { OperatorOverloadType.NotEqual, "!=" },
                { OperatorOverloadType.Or, "|" },
                { OperatorOverloadType.Plus, "+" },
                { OperatorOverloadType.RightShift, ">>" },
                { OperatorOverloadType.True, "true" }
            };

        public WriteOperatorOverloadType(OperatorOverloadType operatorType)
        {
            OperatorType = operatorType;
        }

        public OperatorOverloadType OperatorType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(operatorTypes[OperatorType]);
        }
    }
}
