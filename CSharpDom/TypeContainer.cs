using System.Collections.ObjectModel;

namespace CSharpDom
{
    internal abstract class TypeContainer : AbstractNode, ITypeContainer
    {
        protected TypeContainer()
        {
            Classes = new Collection<ClassNode>();
            Delegates = new Collection<DelegateNode>();
            Enums = new Collection<EnumNode>();
            Interfaces = new Collection<InterfaceNode>();
            Structs = new Collection<StructNode>();
        }

        public Collection<ClassNode> Classes { get; private set; }

        public Collection<DelegateNode> Delegates { get; private set; }

        public Collection<EnumNode> Enums { get; private set; }

        public Collection<InterfaceNode> Interfaces { get; private set; }

        public Collection<StructNode> Structs { get; private set; }
    }
}
