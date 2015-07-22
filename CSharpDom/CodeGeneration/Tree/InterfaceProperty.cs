using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceProperty : CodeGenerationNode
    {
        public InterfaceProperty(string name, InterfacePropertyAccessors accessors)
        {
            Name = name;
            Accessors = accessors;
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public InterfacePropertyAccessors Accessors { get; set; }

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
