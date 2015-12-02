﻿namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UnaryOperator : CodeGenerationNode
    {
        public UnaryOperator(UnaryOperatorType unaryOperatorType)
        {
            OperatorType = unaryOperatorType;
            Body = new CodeGenerationCollection<Statement>();
        }

        public UnaryOperatorType OperatorType { get; set; }

        public TypeReference ReturnType { get; set; }

        public string ParameterName { get; set; }

        public TypeReference ParameterType { get; set; }

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
            Body.AcceptIfNotNull(visitor);
        }
    }
}
