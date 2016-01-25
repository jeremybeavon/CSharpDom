using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UnaryOperator
    {
        public UnaryOperator(UnaryOperatorType unaryOperatorType)
        {
            OperatorType = unaryOperatorType;
            Body = new Collection<Statement>();
        }

        public UnaryOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public string ParameterName { get; set; }

        public TypeReference ParameterType { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
