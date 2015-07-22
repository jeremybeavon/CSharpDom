using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceMethod : CodeGenerationNode
    {
        public InterfaceMethod(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<MethodParameter>();
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

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
            Parameters.AcceptIfNotNull(visitor);
        }
    }
}
