using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ConversionOperator
    {
        public ConversionOperator()
        {
            Attributes = new Collection<AttributeGroup>();
            Body = new Collection<Statement>();
            ParameterName = "parameter";
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ConversionOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public TypeReference ParameterType { get; set; }

        public string ParameterName { get; set; }

        public Collection<Statement> Body { get; set; }

        public override string ToString()
        {
            return new ReadOnlyConversionOperator(this).ToSourceCode();
        }
    }
}
