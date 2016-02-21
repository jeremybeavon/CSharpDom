using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class TypeContainer
    {
        public TypeContainer()
        {
            AbstractClasses = new List<AbstractClassWithReflection>();
            Classes = new List<ClassWithReflection>();
            SealedClasses = new List<SealedClassWithReflection>();
            StaticClasses = new List<StaticClassWithReflection>();
            Delegates = new List<DelegateWithReflection>();
            Enums = new List<EnumWithReflection>();
            Interfaces = new List<InterfaceWithReflection>();
            Structs = new List<StructWithReflection>();
        }

        public List<AbstractClassWithReflection> AbstractClasses { get; private set; }

        public List<ClassWithReflection> Classes { get; private set; }

        public List<SealedClassWithReflection> SealedClasses { get; set; }

        public List<StaticClassWithReflection> StaticClasses { get; set; }

        public List<DelegateWithReflection> Delegates { get; private set; }

        public List<EnumWithReflection> Enums { get; private set; }

        public List<InterfaceWithReflection> Interfaces { get; private set; }

        public List<StructWithReflection> Structs { get; private set; }
    }
}
