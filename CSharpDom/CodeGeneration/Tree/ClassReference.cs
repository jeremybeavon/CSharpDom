using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassReference : CodeGenerationNode
    {
        private object reference;

        public ClassReference(Type type)
        {
            reference = type;
        }

        public ClassReference(Class @class)
        {
            reference = @class;
        }

        public ClassReference(ClassNestedClass @class)
        {
            reference = @class;
        }

        public ClassReference(StructNestedClass @class)
        {
            reference = @class;
        }

        public ClassReference(string type)
        {
            reference = type;
        }

        public Type Type
        {
            get { return reference as Type; }
            set { reference = value; }
        }

        public Class Class
        {
            get { return reference as Class; }
            set { reference = value; }
        }

        public ClassNestedClass ClassNestedClass
        {
            get { return reference as ClassNestedClass; }
            set { reference = value; }
        }

        public StructNestedClass StructNestedClass
        {
            get { return reference as StructNestedClass; }
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
        }
    }
}
