using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassAccessor
    {
        public ClassAccessor()
        {
            Body = new Collection<Statement>();
        }

        public ClassAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
