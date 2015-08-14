using System;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceReference : Statement
    {
        private object reference;

        public InterfaceReference(Type type)
        {
            reference = type;
        }

        public InterfaceReference(Interface @interface)
        {
            reference = @interface;
        }

        public InterfaceReference(ClassNestedInterface @interface)
        {
            reference = @interface;
        }

        public InterfaceReference(StructNestedInterface @interface)
        {
            reference = @interface;
        }

        public InterfaceReference(string type)
        {
            reference = type;
        }

        public Type Type
        {
            get { return reference as Type; }
            set { reference = value; }
        }

        public Interface Interface
        {
            get { return reference as Interface; }
            set { reference = value; }
        }

        public ClassNestedInterface ClassNestedInterface
        {
            get { return reference as ClassNestedInterface; }
            set { reference = value; }
        }

        public StructNestedInterface StructNestedInterface
        {
            get { return reference as StructNestedInterface; }
            set { reference = value; }
        }

        public string TypeText
        {
            get { return reference as string; }
            set { reference = value; }
        }

        public CodeGenerationCollection<TypeReference> GenericParameters { get; set; }

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
        }
    }
}
