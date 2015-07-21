using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class BlockStatement : Statement
    {
        public BlockStatement()
        {
            Statements = new Collection<Statement>();
        }

        public Collection<Statement> Statements { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
