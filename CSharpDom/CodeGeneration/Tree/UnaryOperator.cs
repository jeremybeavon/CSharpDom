using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UnaryOperator
    {
        public UnaryOperator(UnaryOperatorType unaryOperatorType)
        {
            OperatorType = unaryOperatorType;
            Body = new Collection<Statement>();
            switch (unaryOperatorType)
            {
                case UnaryOperatorType.LogicalNot:
                case UnaryOperatorType.True:
                case UnaryOperatorType.False:
                    ReturnType = new TypeReference(typeof(bool));
                    break;
            }
        }

        public UnaryOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public string ParameterName { get; set; }

        public TypeReference ParameterType { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
