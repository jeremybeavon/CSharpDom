using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceAccessor
    {
        public InterfaceAccessor()
        {
            Attributes = new Collection<AttributeGroup>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }
    }
}
