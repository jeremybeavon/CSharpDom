using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class TryStatement : Statement
    {
        public TryStatement()
        {
            TryStatements = new Collection<Statement>();
            CatchStatements = new Collection<CatchStatement>();
        }

        public Collection<Statement> TryStatements { get; set; }

        public Collection<CatchStatement> CatchStatements { get; set; }

        public FinallyStatement FinallyStatement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
