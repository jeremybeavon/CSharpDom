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
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedInterfaceCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
