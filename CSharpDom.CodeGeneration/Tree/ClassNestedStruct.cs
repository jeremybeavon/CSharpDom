namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassNestedStruct : CodeGenerationNode
    {
        public ClassNestedStruct(string name)
        {
            Name = name;
            Body = new StructBody();
            GenericParameters = new CodeGenerationCollection<GenericParameter>();
            Interfaces = new CodeGenerationCollection<InterfaceReference>();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsPartial { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<InterfaceReference> Interfaces { get; set; }

        public StructBody Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            GenericParameters.AcceptIfNotNull(visitor);
            Interfaces.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
