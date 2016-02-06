namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SealedClassEvent
    {
        public SealedClassEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public SealedClassMemberVisibilityModifier Visibility { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }
    }
}
