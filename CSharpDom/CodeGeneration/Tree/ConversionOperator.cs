using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ConversionOperator
    {
        public ConversionOperator()
        {
            Body = new Collection<Statement>();
            ParameterName = "parameter";
        }

        public ConversionOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public TypeReference ParameterType { get; set; }

        public string ParameterName { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
