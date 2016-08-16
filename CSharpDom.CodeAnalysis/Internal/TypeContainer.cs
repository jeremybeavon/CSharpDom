using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class TypeContainer
    {
        public TypeContainer()
        {
            AbstractClasses = new List<AbstractClassWithCodeAnalysis>();
            Classes = new List<ClassWithCodeAnalysis>();
            SealedClasses = new List<SealedClassWithCodeAnalysis>();
            StaticClasses = new List<StaticClassWithCodeAnalysis>();
            Delegates = new List<DelegateWithCodeAnalysis>();
            Enums = new List<EnumWithCodeAnalysis>();
            Interfaces = new List<InterfaceWithCodeAnalysis>();
            Structs = new List<StructWithCodeAnalysis>();
        }

        public List<AbstractClassWithCodeAnalysis> AbstractClasses { get; private set; }

        public List<ClassWithCodeAnalysis> Classes { get; private set; }

        public List<SealedClassWithCodeAnalysis> SealedClasses { get; set; }

        public List<StaticClassWithCodeAnalysis> StaticClasses { get; set; }

        public List<DelegateWithCodeAnalysis> Delegates { get; private set; }

        public List<EnumWithCodeAnalysis> Enums { get; private set; }

        public List<InterfaceWithCodeAnalysis> Interfaces { get; private set; }

        public List<StructWithCodeAnalysis> Structs { get; private set; }
    }
}
