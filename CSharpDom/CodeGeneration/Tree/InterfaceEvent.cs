using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceEvent : CodeGenerationNode
    {
        public InterfaceEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public DelegateReference Type { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
