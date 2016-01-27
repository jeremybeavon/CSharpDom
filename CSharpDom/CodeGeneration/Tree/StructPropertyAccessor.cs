using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructPropertyAccessor
    {
        public StructPropertyAccessor()
        {
            Body = new Collection<Statement>();
        }

        public StructPropertyAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
