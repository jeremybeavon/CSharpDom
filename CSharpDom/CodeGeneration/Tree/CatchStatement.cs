using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CatchStatement
    {
        public CatchStatement()
        {
            Statements = new Collection<Statement>();
        }

        public TypeReference Type { get; set; }

        public string Name { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
