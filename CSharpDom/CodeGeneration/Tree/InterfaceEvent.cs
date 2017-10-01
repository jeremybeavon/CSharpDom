using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceEvent
    {
        public InterfaceEvent(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public DelegateReference Type { get; set; }

        public override string ToString()
        {
            return new ReadOnlyInterfaceEvent(this).ToSourceCode();
        }
    }
}
