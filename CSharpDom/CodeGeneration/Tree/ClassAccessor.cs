using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassAccessor
    {
        public ClassAccessor()
        {
            Attributes = new Collection<AttributeGroup>();
            Body = new Collection<Statement>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }

        public override string ToString()
        {
            return new ReadOnlyClassAccessor(this).ToSourceCode();
        }
    }
}
