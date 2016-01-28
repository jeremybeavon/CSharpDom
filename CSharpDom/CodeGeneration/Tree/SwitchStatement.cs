using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchStatement : Statement
    {
        public ExpressionStatement Expression { get; set; }

        public Collection<SwitchCaseStatement> Cases { get; set; }

        public Collection<Statement> DefaultCase { get; set; }
    }
}
