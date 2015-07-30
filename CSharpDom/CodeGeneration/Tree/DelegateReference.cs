using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DelegateReference : CodeGenerationNode
    {
        private object reference;

        public DelegateReference(Type type)
        {
            reference = type;
        }

        public DelegateReference(Delegate @delegate)
        {
            reference = @delegate;
        }

        public DelegateReference(ClassNestedDelegate @delegate)
        {
            reference = @delegate;
        }

        public DelegateReference(StructNestedDelegate @delegate)
        {
            reference = @delegate;
        }

        public DelegateReference(string type)
        {
            reference = type;
        }

        public Type Type
        {
            get { return reference as Type; }
            set { reference = value; }
        }

        public Delegate Delegate
        {
            get { return reference as Delegate; }
            set { reference = value; }
        }

        public ClassNestedDelegate ClassNestedDelegate
        {
            get { return reference as ClassNestedDelegate; }
            set { reference = value; }
        }

        public StructNestedDelegate StructNestedDelegate
        {
            get { return reference as StructNestedDelegate; }
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
