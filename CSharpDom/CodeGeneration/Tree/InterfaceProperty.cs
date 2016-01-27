namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceProperty
    {
        public InterfaceProperty(string name, InterfacePropertyAccessors accessors)
        {
            Name = name;
            Accessors = accessors;
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public TypeReference Type { get; set; }

        public InterfacePropertyAccessors Accessors { get; set; }
    }
}
