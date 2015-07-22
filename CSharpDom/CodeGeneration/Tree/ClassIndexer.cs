using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassIndexer : CodeGenerationNode
    {
        public ClassIndexer(string name)
        {
            Name = name;
            Parameters = new Collection<MethodParameter>();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public ClassPropertyAccessor GetAccessor { get; set; }

        public ClassPropertyAccessor SetAccessor { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
