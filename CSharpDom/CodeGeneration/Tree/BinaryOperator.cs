using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class BinaryOperator : CodeGenerationNode
    {
        public BinaryOperator(BinaryOperatorType operatorType)
        {
            OperatorType = operatorType;
        }

        public BinaryOperatorType OperatorType { get; set; }

        public TypeReference Parameter1 { get; set; }

        public TypeReference Parameter2 { get; set; }

        public TypeReference Output { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
