using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructPropertyAccessor : CodeGenerationNode
    {
        public StructPropertyAccessor()
        {
            Body = new CodeGenerationCollection<Statement>();
        }

        public StructPropertyAccessorVisibilityModifier Visibility { get; set; }

        public CodeGenerationCollection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Body.AcceptIfNotNull(visitor);
        }
    }
}
