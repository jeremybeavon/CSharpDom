namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Delegate : CodeGenerationNode
    {
        public Delegate(string name)
        {
            Name = name;
            GenericParameters = new CodeGenerationCollection<GenericParameter>();
            Parameters = new CodeGenerationCollection<MethodParameter>();
        }

        public TypeVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public TypeReference ReturnType { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<MethodParameter> Parameters { get; set; }

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
            Parameters.AcceptIfNotNull(visitor);
        }
    }
}
