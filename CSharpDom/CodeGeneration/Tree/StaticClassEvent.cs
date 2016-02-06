namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassEvent
    {
        public StaticClassEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }
        
        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
