using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedInterfaceCollectionWithReflection :
        AbstractClassNestedInterfaceCollection<ClassNestedInterfaceWithReflection, PartialInterfaceNotSupported>
    {
        private readonly AbstractClassNestedInterfaceCollection interfaceCollection;

        internal ClassNestedInterfaceCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            interfaceCollection = new ClassNestedInterfaceCollection(typeWithReflection);
        }

        internal ClassNestedInterfaceCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            interfaceCollection = new SealedClassNestedInterfaceCollection(typeWithReflection);
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return interfaceCollection; }
        }
    }
}
