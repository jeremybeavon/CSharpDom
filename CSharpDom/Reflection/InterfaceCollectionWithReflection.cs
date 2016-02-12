using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceCollectionWithReflection :
        AbstractInterfaceCollection<InterfaceWithReflection, PartialInterfaceNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal InterfaceCollectionWithReflection(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<InterfaceWithReflection> Interfaces
        {
            get { return typeContainer.Interfaces; }
        }
    }
}
