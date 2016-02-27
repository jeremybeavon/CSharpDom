using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedInterfaceCollectionWithMonoCecil :
        AbstractStaticClassNestedInterfaceCollection<StaticClassNestedInterfaceWithMonoCecil, PartialInterfaceNotSupported>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassNestedInterfaceCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}
