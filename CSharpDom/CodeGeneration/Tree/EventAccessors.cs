using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EventAccessors
    {
        public EventAccessors()
        {
            AddBody = new Collection<Statement>();
            RemoveBody = new Collection<Statement>();
        }

        public Collection<Statement> AddBody { get; set; }

        public Collection<Statement> RemoveBody { get; set; }
    }
}
