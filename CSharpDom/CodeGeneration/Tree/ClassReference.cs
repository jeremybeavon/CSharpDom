using System;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassReference
    {
        private object reference;

        public ClassReference()
        {
            GenericParameters = new Collection<TypeReference>();
        }

        public ClassReference(Type type)
            : this()
        {
            reference = type;
        }

        public ClassReference(Class @class)
            : this()
        {
            reference = @class;
        }

        public ClassReference(ClassNestedClass @class)
            : this()
        {
            reference = @class;
        }

        public ClassReference(StructNestedClass @class)
            : this()
        {
            reference = @class;
        }

        public ClassReference(string type)
            : this()
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

        public Collection<TypeReference> GenericParameters { get; set; }
    }
}
