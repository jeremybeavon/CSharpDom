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
            Body = new Collection<Statement>();
        }

        public StructPropertyAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
