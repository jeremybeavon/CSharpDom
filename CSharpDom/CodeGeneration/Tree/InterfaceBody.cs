using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceBody : CodeGenerationNode
    {
        public InterfaceBody()
        {
            Events = new CodeGenerationCollection<InterfaceEvent>();
            Properties = new CodeGenerationCollection<InterfaceProperty>();
            Methods = new CodeGenerationCollection<InterfaceMethod>();
        }

        public CodeGenerationCollection<InterfaceEvent> Events { get; set; }

        public CodeGenerationCollection<InterfaceProperty> Properties { get; set; }

        public CodeGenerationCollection<InterfaceMethod> Methods { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Events.AcceptIfNotNull(visitor);
            Properties.AcceptIfNotNull(visitor);
            Methods.AcceptIfNotNull(visitor);
        }
    }
}
