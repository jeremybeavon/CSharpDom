namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructIndexer : CodeGenerationNode
    {
        public StructIndexer(string name)
        {
            Name = name;
            Parameters = new CodeGenerationCollection<MethodParameter>();
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public TypeReference Type { get; set; }

        public CodeGenerationCollection<MethodParameter> Parameters { get; set; }

        public ClassPropertyAccessor GetAccessor { get; set; }

        public ClassPropertyAccessor SetAccessor { get; set; }

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
            Parameters.AcceptIfNotNull(visitor);
            GetAccessor.AcceptIfNotNull(visitor);
            SetAccessor.AcceptIfNotNull(visitor);
        }
    }
}
