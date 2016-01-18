namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructMethod : CodeGenerationNode
    {
        public StructMethod(string name)
        {
            Name = name;
            Parameters = new CodeGenerationCollection<MethodParameter>();
            Body = new CodeGenerationCollection<Statement>();
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public StructMethodInheritanceModifier InheritanceModifier { get; set; }

        public bool IsAsync { get; set; }

        public bool IsPartial { get; set; }

        public TypeReference ReturnType { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<MethodParameter> Parameters { get; set; }

        public CodeGenerationCollection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            ReturnType.AcceptIfNotNull(visitor);
            GenericParameters.AcceptIfNotNull(visitor);
            Parameters.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
