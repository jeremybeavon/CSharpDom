using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Enum
    {
        public Enum(string name)
        {
            Name = name;
            Fields = new Collection<EnumField>();
        }

        public TypeVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }
    }
}
