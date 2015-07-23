using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Enum : CodeGenerationNode
    {
        public Enum(string name)
        {
            Name = name;
            Fields = new CodeGenerationCollection<EnumField>();
        }

        public TypeVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public CodeGenerationCollection<EnumField> Fields { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Fields.AcceptIfNotNull(visitor);
        }
    }
}
