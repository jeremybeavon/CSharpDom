using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructEvent : CodeGenerationNode
    {
        public StructEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            Accessors.AcceptIfNotNull(visitor);
        }
    }
}
