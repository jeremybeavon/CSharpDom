namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceEvent
    {
        public InterfaceEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public DelegateReference Type { get; set; }
    }
}
