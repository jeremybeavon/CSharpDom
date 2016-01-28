using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchCaseStatement : Statement
    {
        public ExpressionStatement Match { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
