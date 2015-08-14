﻿namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceMethod : CodeGenerationNode
    {
        public InterfaceMethod(string name)
        {
            Name = name;
            GenericParameters = new CodeGenerationCollection<GenericParameter>();
            Parameters = new CodeGenerationCollection<MethodParameter>();
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

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
            ReturnType.AcceptIfNotNull(visitor);
            GenericParameters.AcceptIfNotNull(visitor);
            Parameters.AcceptIfNotNull(visitor);
        }
    }
}
