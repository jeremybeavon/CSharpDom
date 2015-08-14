namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassFieldDeclaration : CodeGenerationNode
    {
        public ClassFieldDeclaration()
        {
            Fields = new CodeGenerationCollection<Field>();
        }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public FieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public CodeGenerationCollection<Field> Fields { get; set; }

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
            Fields.AcceptIfNotNull(visitor);
        }
    }
}
