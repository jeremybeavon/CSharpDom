using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceEvent
    {
        public ExplicitInterfaceEvent(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
