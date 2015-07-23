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
            Parameters = new CodeGenerationCollection<MethodParameter>();
            Body = new CodeGenerationCollection<Statement>();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsAsync { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public CodeGenerationCollection<GenericParameter> GenericParameters { get; set; }

        public CodeGenerationCollection<MethodParameter> Parameters { get; set; }

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
            GenericParameters.AcceptIfNotNull(visitor);
            Parameters.AcceptIfNotNull(visitor);
            Body.AcceptIfNotNull(visitor);
        }
    }
}
