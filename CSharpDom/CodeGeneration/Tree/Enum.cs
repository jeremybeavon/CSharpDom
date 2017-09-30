using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Enum
    {
        public Enum(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Fields = new Collection<EnumField>();
            Visibility = TypeVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }
    }
}
