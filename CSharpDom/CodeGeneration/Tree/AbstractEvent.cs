using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractEvent
    {
        public AbstractEvent(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Visibility = AbstractMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public AbstractMemberVisibilityModifier Visibility { get; set; }
        
        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
