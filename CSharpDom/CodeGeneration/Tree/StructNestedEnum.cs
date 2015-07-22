using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedEnum : CodeGenerationNode
    {
        public StructNestedEnum(string name)
        {
            Name = name;
            Fields = new Collection<EnumField>();
        }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }

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
