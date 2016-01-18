namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class MethodParameter : CodeGenerationNode
    {
        public MethodParameter(string name)
        {
            Name = name;
        }

        public MethodParameter(string name, TypeReference type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }

        public MethodParameterModifier Modifier { get; set; }

        public TypeReference Type { get; set; }

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
