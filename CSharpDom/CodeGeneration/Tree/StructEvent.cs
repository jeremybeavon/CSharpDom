using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructEvent
    {
        public StructEvent(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Visibility = StructMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public bool IsStatic { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }

        internal bool IsEventProperty
        {
            get { return Accessors != null; }
        }
    }
}
