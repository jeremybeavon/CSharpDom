using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassEvent
    {
        public ClassEvent(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Visibility = ClassMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }

        internal bool IsEventProperty
        {
            get { return Accessors != null; }
        }
    }
}
