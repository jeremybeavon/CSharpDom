using System;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public class TypeReference : Statement
    {
        private object reference;

        public TypeReference()
        {
            GenericParameters = new Collection<TypeReference>();
        }

        public TypeReference(Type type)
            : this()
        {
            reference = type;
        }

        public TypeReference(Class @class)
            : this()
        {
            reference = @class;
        }

        public TypeReference(ClassNestedClass @class)
            : this()
        {
            reference = @class;
        }

        public TypeReference(ClassNestedDelegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public TypeReference(ClassNestedEnum @enum)
            : this()
        {
            reference = @enum;
        }

        public TypeReference(ClassNestedInterface @interface)
            : this()
        {
            reference = @interface;
        }

        public TypeReference(ClassNestedStruct @struct)
            : this()
        {
            reference = @struct;
        }

        public TypeReference(Delegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public TypeReference(Enum @enum)
            : this()
        {
            reference = @enum;
        }

        public TypeReference(GenericParameter genericParameter)
            : this()
        {
            reference = genericParameter;
        }

        public TypeReference(Interface @interface)
            : this()
        {
            reference = @interface;
        }

        public TypeReference(Struct @struct)
            : this()
        {
            reference = @struct;
        }

        public TypeReference(StructNestedClass @class)
            : this()
        {
            reference = @class;
        }

        public TypeReference(StructNestedDelegate @delegate)
            : this()
        {
            reference = @delegate;
        }

        public TypeReference(StructNestedEnum @enum)
            : this()
        {
            reference = @enum;
        }

        public TypeReference(StructNestedInterface @interface)
            : this()
        {
            reference = @interface;
        }

        public TypeReference(StructNestedStruct @struct)
            : this()
        {
            reference = @struct;
        }

        public TypeReference(string type)
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

        public ClassNestedDelegate ClassNestedDelegate
        {
            get { return reference as ClassNestedDelegate; }
            set { reference = value; }
        }

        public ClassNestedEnum ClassNestedEnum
        {
            get { return reference as ClassNestedEnum; }
            set { reference = value; }
        }

        public ClassNestedInterface ClassNestedInterface
        {
            get { return reference as ClassNestedInterface; }
            set { reference = value; }
        }

        public ClassNestedStruct ClassNestedStruct
        {
            get { return reference as ClassNestedStruct; }
            set { reference = value; }
        }

        public Delegate Delegate
        {
            get { return reference as Delegate; }
            set { reference = value; }
        }

        public Enum Enum
        {
            get { return reference as Enum; }
            set { reference = value; }
        }

        public GenericParameter GenericParameter
        {
            get { return reference as GenericParameter; }
            set { reference = value; }
        }

        public Interface Interface
        {
            get { return reference as Interface; }
            set { reference = value; }
        }

        public Struct Struct
        {
            get { return reference as Struct; }
            set { reference = value; }
        }

        public StructNestedClass StructNestedClass
        {
            get { return reference as StructNestedClass; }
            set { reference = value; }
        }

        public StructNestedDelegate StructNestedDelegate
        {
            get { return reference as StructNestedDelegate; }
            set { reference = value; }
        }

        public StructNestedEnum StructNestedEnum
        {
            get { return reference as StructNestedEnum; }
            set { reference = value; }
        }

        public StructNestedInterface StructNestedInterface
        {
            get { return reference as StructNestedInterface; }
            set { reference = value; }
        }

        public StructNestedStruct StructNestedStruct
        {
            get { return reference as StructNestedStruct; }
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
