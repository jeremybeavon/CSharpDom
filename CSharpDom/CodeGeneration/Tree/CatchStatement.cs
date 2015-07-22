using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CatchStatement : CodeGenerationNode
    {
        public CatchStatement()
        {
            Statements = new Collection<Statement>();
        }

        public TypeReference Type { get; set; }

        public string Name { get; set; }

        public Collection<Statement> Statements { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
