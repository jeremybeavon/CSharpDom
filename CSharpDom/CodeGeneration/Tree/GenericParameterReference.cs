using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GenericParameterReference : CodeGenerationNode
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
