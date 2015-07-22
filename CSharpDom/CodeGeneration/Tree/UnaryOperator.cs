using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UnaryOperator : CodeGenerationNode
    {
        public UnaryOperator(UnaryOperatorType unaryOperatorType)
        {
            OperatorType = unaryOperatorType;
            Body = new Collection<Statement>();
        }

        public UnaryOperatorType OperatorType { get; set; }

        public Collection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Body.AcceptIfNotNull(visitor);
        }
    }
}
