using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Namespace : TypeContainer
    {
        public Namespace(string name)
        {
            Name = name;
            Usings = new CodeGenerationCollection<UsingDeclaration>();
            Namespaces = new CodeGenerationCollection<Namespace>();
        }

        public CodeGenerationCollection<UsingDeclaration> Usings { get; set; }

        public string Name { get; set; }

        public CodeGenerationCollection<Namespace> Namespaces { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Usings.AcceptIfNotNull(visitor);
            Namespaces.AcceptIfNotNull(visitor);
        }
    }
}
