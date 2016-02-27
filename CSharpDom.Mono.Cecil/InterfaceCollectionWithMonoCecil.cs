using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceCollectionWithMonoCecil :
        AbstractInterfaceCollection<InterfaceWithMonoCecil, PartialInterfaceNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal InterfaceCollectionWithMonoCecil(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<InterfaceWithMonoCecil> Interfaces
        {
            get { return typeContainer.Interfaces; }
        }
    }
}
