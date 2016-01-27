using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassPropertyAccessor
    {
        public ClassPropertyAccessor()
        {
            Body = new Collection<Statement>();
        }

        public ClassPropertyAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
