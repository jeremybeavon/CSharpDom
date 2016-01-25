using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassFieldDeclaration
    {
        public ClassFieldDeclaration(TypeReference type)
        {
            Type = type;
            Fields = new Collection<Field>();
        }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public FieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
