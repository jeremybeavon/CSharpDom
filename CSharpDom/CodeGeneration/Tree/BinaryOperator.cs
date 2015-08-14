namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class BinaryOperator : CodeGenerationNode
    {
        public BinaryOperator(BinaryOperatorType operatorType)
        {
            OperatorType = operatorType;
            Parameter1Name = "parameter1";
            Parameter2Name = "parameter2";
        }

        public BinaryOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public TypeReference Parameter1Type { get; set; }

        public string Parameter1Name { get; set; }

        public TypeReference Parameter2Type { get; set; }

        public string Parameter2Name { get; set; }

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
            Parameter1Type.AcceptIfNotNull(visitor);
            Parameter2Type.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
