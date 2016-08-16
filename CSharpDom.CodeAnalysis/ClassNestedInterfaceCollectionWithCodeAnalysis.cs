using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedInterfaceCollectionWithCodeAnalysis :
        AbstractClassNestedInterfaceCollection<ClassNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly AbstractClassNestedInterfaceCollection interfaceCollection;

        internal ClassNestedInterfaceCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            interfaceCollection = new ClassNestedInterfaceCollection(typeWithCodeAnalysis);
        }

        internal ClassNestedInterfaceCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            interfaceCollection = new SealedClassNestedInterfaceCollection(typeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaceCollection; }
        }
    }
}
