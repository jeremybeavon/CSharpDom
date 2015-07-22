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
            AddBody = new Collection<Statement>();
            RemoveBody = new Collection<Statement>();
        }

        public Collection<Statement> AddBody { get; set; }

        public Collection<Statement> RemoveBody { get; set; }

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
