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
            Events = new Collection<InterfaceEvent>();
            Properties = new Collection<InterfaceProperty>();
            Methods = new Collection<InterfaceMethod>();
        }

        public Collection<InterfaceEvent> Events { get; set; }

        public Collection<InterfaceProperty> Properties { get; set; }

        public Collection<InterfaceMethod> Methods { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
