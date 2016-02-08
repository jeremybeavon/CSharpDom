using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassField
    {
        public StaticClassField(TypeReference type)
        {
            Type = type;
            Fields = new Collection<Field>();
        }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }

        public StaticClassFieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
