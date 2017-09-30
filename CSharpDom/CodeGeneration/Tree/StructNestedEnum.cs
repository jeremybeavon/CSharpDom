using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedEnum
    {
        public StructNestedEnum(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Fields = new Collection<EnumField>();
            Visibility = StructMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }
    }
}
