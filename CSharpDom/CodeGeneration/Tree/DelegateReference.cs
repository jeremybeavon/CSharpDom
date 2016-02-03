using System;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DelegateReference
    {
        private object reference;

        public DelegateReference()
        {
            GenericParameters = new Collection<TypeReference>();
        }

        public DelegateReference(Type type)
            : this()
        {
            reference = type;
        }

        public DelegateReference(Delegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public DelegateReference(ClassNestedDelegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public DelegateReference(StructNestedDelegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public DelegateReference(string type)
            : this()
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

        public Collection<TypeReference> GenericParameters { get; set; }
    }
}
