using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassAccessor
    {
        public StaticClassAccessor()
        {
            Body = new Collection<Statement>();
        }

        public ClassAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
