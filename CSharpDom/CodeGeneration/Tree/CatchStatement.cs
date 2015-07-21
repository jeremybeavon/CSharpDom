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
            throw new NotImplementedException();
        }
    }
}
