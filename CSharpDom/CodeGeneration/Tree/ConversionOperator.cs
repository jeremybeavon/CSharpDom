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
            Body = new CodeGenerationCollection<Statement>();
            ParameterName = "parameter";
        }

        public ConversionOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public TypeReference ParameterType { get; set; }

        public string ParameterName { get; set; }

        public CodeGenerationCollection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            ReturnType.AcceptIfNotNull(visitor);
            ParameterType.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
