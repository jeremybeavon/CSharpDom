namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedEnum : CodeGenerationNode
    {
        public StructNestedEnum(string name)
        {
            Name = name;
            Fields = new CodeGenerationCollection<EnumField>();
        }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public CodeGenerationCollection<EnumField> Fields { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Fields.AcceptIfNotNull(visitor);
        }
    }
}
