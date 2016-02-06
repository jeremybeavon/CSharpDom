using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassNestedEnum
    {
        public StaticClassNestedEnum(string name)
        {
            Name = name;
            Fields = new Collection<EnumField>();
        }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }
    }
}
