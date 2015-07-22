using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructFieldDeclaration : CodeGenerationNode
    {
        public StructFieldDeclaration()
        {
            Fields = new Collection<Field>();
        }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public FieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }

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
            Fields.AcceptIfNotNull(visitor);
        }
    }
}
