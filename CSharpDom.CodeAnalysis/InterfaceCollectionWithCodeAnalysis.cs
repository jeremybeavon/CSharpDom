using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceCollectionWithCodeAnalysis :
        AbstractInterfaceCollection<InterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal InterfaceCollectionWithCodeAnalysis(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<InterfaceWithCodeAnalysis> Interfaces
        {
            get { return typeContainer.Interfaces; }
        }
    }
}
