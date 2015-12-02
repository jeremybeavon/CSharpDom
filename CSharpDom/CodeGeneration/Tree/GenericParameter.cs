namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GenericParameter : CodeGenerationNode
    {
        public GenericParameter(string name)
        {
            Name = name;
            GenericParameterConstraints = new CodeGenerationCollection<GenericParameterReference>();
            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>();
        }

        public string Name { get; set; }

        public GenericParameterTypeConstraintModifier TypeConstraint { get; set; }

        public ClassReference BaseClassConstraint { get; set; }

        public CodeGenerationCollection<GenericParameterReference> GenericParameterConstraints { get; set; }

        public CodeGenerationCollection<InterfaceReference> InterfaceConstraints { get; set; }

        public bool HasEmptyConstructorConstraint { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            BaseClassConstraint.AcceptIfNotNull(visitor);
            GenericParameterConstraints.AcceptIfNotNull(visitor);
            InterfaceConstraints.AcceptIfNotNull(visitor);
        }
    }
}
