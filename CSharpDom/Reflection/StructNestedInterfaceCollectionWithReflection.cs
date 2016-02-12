using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedInterfaceCollectionWithReflection :
        AbstractStructNestedInterfaceCollection<StructNestedInterfaceWithReflection, PartialInterfaceNotSupported>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructNestedInterfaceCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
