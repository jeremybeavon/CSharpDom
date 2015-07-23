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
        }

        public ConversionOperatorType OperatorType { get; set; }

        public TypeReference InputType { get; set; }

        public TypeReference OutputType { get; set; }

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
            InputType.AcceptIfNotNull(visitor);
            OutputType.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
