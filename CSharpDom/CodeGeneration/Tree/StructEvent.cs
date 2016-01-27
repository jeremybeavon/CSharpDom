namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructEvent
    {
        public StructEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public bool IsStatic { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
