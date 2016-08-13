using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructAccessor
    {
        public StructAccessor()
        {
            Attributes = new Collection<AttributeGroup>();
            Body = new Collection<Statement>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public StructAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
