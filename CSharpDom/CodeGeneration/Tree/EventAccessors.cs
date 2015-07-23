using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EventAccessors : CodeGenerationNode
    {
        public EventAccessors()
        {
            AddBody = new CodeGenerationCollection<Statement>();
            RemoveBody = new CodeGenerationCollection<Statement>();
        }

        public CodeGenerationCollection<Statement> AddBody { get; set; }

        public CodeGenerationCollection<Statement> RemoveBody { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            AddBody.AcceptIfNotNull(visitor);
            RemoveBody.AcceptIfNotNull(visitor);
        }
    }
}
