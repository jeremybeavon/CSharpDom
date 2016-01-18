namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceEvent : CodeGenerationNode
    {
        public InterfaceEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public DelegateReference Type { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
        }
    }
}
