using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructIndexer : CodeGenerationNode
    {
        public StructIndexer(string name)
        {
            Name = name;
            Parameters = new Collection<MethodParameter>();
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public ClassPropertyAccessor GetAccessor { get; set; }

        public ClassPropertyAccessor SetAccessor { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Parameters.AcceptIfNotNull(visitor);
            GetAccessor.AcceptIfNotNull(visitor);
            SetAccessor.AcceptIfNotNull(visitor);
        }
    }
}
