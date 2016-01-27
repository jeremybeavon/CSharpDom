using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class BinaryOperator
    {
        public BinaryOperator(BinaryOperatorType operatorType)
        {
            OperatorType = operatorType;
            Parameter1Name = "parameter1";
            Parameter2Name = "parameter2";
        }

        public BinaryOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public TypeReference Parameter1Type { get; set; }

        public string Parameter1Name { get; set; }

        public TypeReference Parameter2Type { get; set; }

        public string Parameter2Name { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
