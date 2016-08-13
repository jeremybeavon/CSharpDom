using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EnumField
    {
        public EnumField(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public string RawInitialValue { get; set; }
    }
}
