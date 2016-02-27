using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructNestedInterfaceCollectionWithMonoCecil :
        AbstractStructNestedInterfaceCollection<StructNestedInterfaceWithMonoCecil, PartialInterfaceNotSupported>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructNestedInterfaceCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
