using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructFieldDeclaration
    {
        public StructFieldDeclaration(TypeReference type)
        {
            Type = type;
            Fields = new Collection<Field>();
        }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public FieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
