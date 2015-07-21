using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassMethod : CodeGenerationNode
    {
        public ClassMethod(string name)
        {
            Name = name;
            Parameters = new Collection<MethodParameter>();
            Body = new BlockStatement();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsAsync { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public BlockStatement Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
