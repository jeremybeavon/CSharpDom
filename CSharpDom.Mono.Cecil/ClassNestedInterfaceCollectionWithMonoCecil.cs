using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassNestedInterfaceCollectionWithMonoCecil :
        AbstractClassNestedInterfaceCollection<ClassNestedInterfaceWithMonoCecil, PartialInterfaceNotSupported>
    {
        private readonly AbstractClassNestedInterfaceCollection interfaceCollection;

        internal ClassNestedInterfaceCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            interfaceCollection = new ClassNestedInterfaceCollection(typeWithMonoCecil);
        }

        internal ClassNestedInterfaceCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            interfaceCollection = new SealedClassNestedInterfaceCollection(typeWithMonoCecil);
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return interfaceCollection; }
        }
    }
}
