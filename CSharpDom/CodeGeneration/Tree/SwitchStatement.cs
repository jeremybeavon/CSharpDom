using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchStatement : Statement
    {
        public IExpressionStatement Expression { get; set; }

        public Collection<SwitchCaseStatement> Cases { get; set; }

        public Collection<Statement> DefaultCase { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
