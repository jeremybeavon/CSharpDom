namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassEvent
    {
        public ClassEvent(string name)
        {
            Name = name;
        }

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
