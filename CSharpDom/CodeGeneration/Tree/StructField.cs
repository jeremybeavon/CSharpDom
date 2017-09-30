using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructField
    {
        public StructField(TypeReference type)
        {
            Type = type;
            Attributes = new Collection<AttributeGroup>();
            Fields = new Collection<Field>();
            Visibility = StructMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public StructFieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
