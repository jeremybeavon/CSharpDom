using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AttributeGroup
    {
        public AttributeGroup()
        {
            Attributes = new Collection<Attribute>();
        }

        public Collection<Attribute> Attributes { get; set; }
    }
}
