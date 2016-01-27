using System;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GenericParameterReference
    {
        private object reference;

        public GenericParameterReference(Type type)
        {
            reference = type;
        }

        public GenericParameterReference(GenericParameter genericParameter)
        {
            reference = genericParameter;
        }

        public GenericParameterReference(string type)
        {
            reference = type;
        }

        public Type Type
        {
            get { return reference as Type; }
            set { reference = value; }
        }

        public GenericParameter GenericParameter
        {
            get { return reference as GenericParameter; }
            set { reference = value; }
        }

        public string TypeText
        {
            get { return reference as string; }
            set { reference = value; }
        }
    }
}
