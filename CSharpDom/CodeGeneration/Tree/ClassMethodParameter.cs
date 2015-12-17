namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassMethodParameter : CodeGenerationNode
    {
        public ClassMethodParameter(string name)
        {
            Name = name;
        }

        public ClassMethodParameter(string name, TypeReference type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }

        public ClassMethodParameterModifier Modifier { get; set; }

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
