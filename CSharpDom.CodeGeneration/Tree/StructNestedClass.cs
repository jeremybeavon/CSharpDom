namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedClass : CodeGenerationNode
    {
        public StructNestedClass(string name)
        {
            Name = name;
            GenericParameters = new CodeGenerationCollection<GenericParameter>();
            Interfaces = new CodeGenerationCollection<InterfaceReference>();
            Body = new ClassBody();
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public TypeInheritanceModifier InheritanceModifier { get; set; }

        public bool IsPartial { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public ClassReference BaseClass { get; set; }

        public CodeGenerationCollection<InterfaceReference> Interfaces { get; set; }

        public ClassBody Body { get; set; }

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
            BaseClass.AcceptIfNotNull(visitor);
            Interfaces.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
