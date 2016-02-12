using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterfaceCollection :
        AbstractInterfaceCollection<ReadOnlyInterface, PartialInterfaceNotSupported>
    {
        private readonly IReadOnlyCollection<ReadOnlyInterface> interfaces;

        public ReadOnlyInterfaceCollection(IEnumerable<Interface> interfaces)
        {
            this.interfaces = interfaces.ToArray(@interface => new ReadOnlyInterface(@interface));
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyInterface> Interfaces
        {
            get { return interfaces; }
        }
    }
}
