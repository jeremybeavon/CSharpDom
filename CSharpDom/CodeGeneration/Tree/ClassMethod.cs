namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassMethod : CodeGenerationNode
    {
        public ClassMethod(string name)
        {
            Name = name;
            Parameters = new CodeGenerationCollection<ClassMethodParameter>();
            Body = new CodeGenerationCollection<Statement>();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsAsync { get; set; }

        public bool IsPartial { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference ReturnType { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<ClassMethodParameter> Parameters { get; set; }

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
            GenericParameters.AcceptIfNotNull(visitor);
            Parameters.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
