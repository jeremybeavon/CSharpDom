namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractProperty
    {
        public AbstractProperty(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference Type { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors { get; set; }
    }
}
