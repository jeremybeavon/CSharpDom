using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceBody
    {
        public InterfaceBody()
        {
            Events = new Collection<InterfaceEvent>();
            Properties = new Collection<InterfaceProperty>();
            Methods = new Collection<InterfaceMethod>();
        }

        public Collection<InterfaceEvent> Events { get; set; }

        public Collection<InterfaceProperty> Properties { get; set; }

        public Collection<InterfaceMethod> Methods { get; set; }
    }
}
