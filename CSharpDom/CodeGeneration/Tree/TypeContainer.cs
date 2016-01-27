using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public abstract class TypeContainer
    {
        protected TypeContainer()
        {
            Classes = new Collection<Class>();
            Delegates = new Collection<Delegate>();
            Enums = new Collection<Enum>();
            Interfaces = new Collection<Interface>();
            Structs = new Collection<Struct>();
        }

        public Collection<Class> Classes { get; set; }

        public Collection<Delegate> Delegates { get; set; }

        public Collection<Enum> Enums { get; set; }

        public Collection<Interface> Interfaces { get; set; }

        public Collection<Struct> Structs { get; set; }
    }
}
