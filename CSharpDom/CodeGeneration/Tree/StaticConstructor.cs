using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticConstructor
    {
        public StaticConstructor()
        {
            Attributes = new Collection<AttributeGroup>();
            Body = new Collection<Statement>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
