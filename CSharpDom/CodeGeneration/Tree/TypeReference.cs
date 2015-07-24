using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class TypeReference : CodeGenerationNode
    {
        private object reference;

        public TypeReference(Type type)
        {
            reference = type;
        }

        public TypeReference(Class @class)
        {
            reference = @class;
        }

        public TypeReference(ClassNestedClass @class)
        {
            reference = @class;
        }

        public TypeReference(ClassNestedDelegate @delegate)
        {
            reference = @delegate;
        }

        public TypeReference(ClassNestedEnum @enum)
        {
            reference = @enum;
        }

        public TypeReference(ClassNestedInterface @interface)
        {
            reference = @interface;
        }

        public TypeReference(ClassNestedStruct @struct)
        {
            reference = @struct;
        }

        public TypeReference(Delegate @delegate)
        {
            reference = @delegate;
        }

        public TypeReference(Enum @enum)
        {
            reference = @enum;
        }

        public TypeReference(GenericParameter genericParameter)
        {
            reference = genericParameter;
        }

        public TypeReference(Interface @interface)
        {
            reference = @interface;
        }

        public TypeReference(Struct @struct)
        {
            reference = @struct;
        }

        public TypeReference(StructNestedClass @class)
        {
            reference = @class;
        }

        public TypeReference(StructNestedDelegate @delegate)
        {
            reference = @delegate;
        }

        public TypeReference(StructNestedEnum @enum)
        {
            reference = @enum;
        }

        public TypeReference(StructNestedInterface @interface)
        {
            reference = @interface;
        }

        public TypeReference(StructNestedStruct @struct)
        {
            reference = @struct;
        }

        public TypeReference(string type)
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
