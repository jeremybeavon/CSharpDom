namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedStruct : CodeGenerationNode
    {
        public StructNestedStruct(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public TypeInheritanceModifier InheritanceModifier { get; set; }

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
