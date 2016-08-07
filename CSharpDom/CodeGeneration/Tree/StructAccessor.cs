using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructAccessor
    {
        public StructAccessor()
        {
            Body = new Collection<Statement>();
        }

        public StructAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
