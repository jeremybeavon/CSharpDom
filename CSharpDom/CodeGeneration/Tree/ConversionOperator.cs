using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ConversionOperator : CodeGenerationNode
    {
        public ConversionOperator()
        {
            Body = new Collection<Statement>();
        }

        public ConversionOperatorType OperatorType { get; set; }

        public TypeReference InputType { get; set; }

        public TypeReference OutputType { get; set; }

        public Collection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
