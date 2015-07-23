using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Interface : CodeGenerationNode
    {
        public Interface(string name)
        {
            Name = name;
            GenericParameters = new CodeGenerationCollection<GenericParameter>();
            Interfaces = new CodeGenerationCollection<InterfaceReference>();
            Body = new InterfaceBody();
        }

        public string Name { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        public TypeInheritanceModifier InheritanceModifier { get; set; }

        public bool IsPartial { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<InterfaceReference> Interfaces { get; set; }

        public InterfaceBody Body { get; set; }

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
            Interfaces.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
