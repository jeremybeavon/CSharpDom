namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceProperty
    {
        public InterfaceProperty(string name, InterfacePropertyAccessors accessors)
        {
            Name = name;
            if (accessors == InterfacePropertyAccessors.Get || accessors == InterfacePropertyAccessors.GetAndSet)
            {
                GetAccessor = new InterfaceAccessor();
            }

            if (accessors == InterfacePropertyAccessors.Set || accessors == InterfacePropertyAccessors.GetAndSet)
            {
                SetAccessor = new InterfaceAccessor();
            }
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public TypeReference Type { get; set; }

        public InterfaceAccessor GetAccessor { get; set; }

        public InterfaceAccessor SetAccessor { get; set; }
    }
}
