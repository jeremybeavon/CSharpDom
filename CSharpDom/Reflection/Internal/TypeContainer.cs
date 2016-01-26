using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class TypeContainer
    {
        public TypeContainer()
        {
            Classes = new List<ClassWithReflection>();
            Delegates = new List<DelegateWithReflection>();
            Enums = new List<EnumWithReflection>();
            Interfaces = new List<InterfaceWithReflection>();
            Structs = new List<StructWithReflection>();
        }

        public List<ClassWithReflection> Classes { get; private set; }

        public List<DelegateWithReflection> Delegates { get; private set; }

        public List<EnumWithReflection> Enums { get; private set; }

        public List<InterfaceWithReflection> Interfaces { get; private set; }

        public List<StructWithReflection> Structs { get; private set; }
    }
}
