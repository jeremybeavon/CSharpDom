using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassField
    {
        public ClassField(TypeReference type)
        {
            Type = type;
            Attributes = new Collection<AttributeGroup>();
            Fields = new Collection<Field>();
            Visibility = ClassMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public ClassFieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }

        public override string ToString()
        {
            return new ReadOnlyClassField(this).ToSourceCode();
        }
    }
}
