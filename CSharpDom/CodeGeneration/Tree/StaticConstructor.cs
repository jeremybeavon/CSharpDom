using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticConstructor
    {
        public StaticConstructor()
        {
            Body = new Collection<Statement>();
        }

        public Collection<Statement> Body { get; set; }
    }
}
