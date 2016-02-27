using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class TypeContainer
    {
        public TypeContainer()
        {
            AbstractClasses = new List<AbstractClassWithMonoCecil>();
            Classes = new List<ClassWithMonoCecil>();
            SealedClasses = new List<SealedClassWithMonoCecil>();
            StaticClasses = new List<StaticClassWithMonoCecil>();
            Delegates = new List<DelegateWithMonoCecil>();
            Enums = new List<EnumWithMonoCecil>();
            Interfaces = new List<InterfaceWithMonoCecil>();
            Structs = new List<StructWithMonoCecil>();
        }

        public List<AbstractClassWithMonoCecil> AbstractClasses { get; private set; }

        public List<ClassWithMonoCecil> Classes { get; private set; }

        public List<SealedClassWithMonoCecil> SealedClasses { get; set; }

        public List<StaticClassWithMonoCecil> StaticClasses { get; set; }

        public List<DelegateWithMonoCecil> Delegates { get; private set; }

        public List<EnumWithMonoCecil> Enums { get; private set; }

        public List<InterfaceWithMonoCecil> Interfaces { get; private set; }

        public List<StructWithMonoCecil> Structs { get; private set; }
    }
}
