namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractEvent
    {
        public AbstractEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
