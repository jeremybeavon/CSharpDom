using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassEvent : CodeGenerationNode
    {
        public ClassEvent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public DelegateReference Type { get; set; }

        public EventAccessors Accessors { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
