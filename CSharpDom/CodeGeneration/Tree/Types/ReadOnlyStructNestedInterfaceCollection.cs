using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedInterfaceCollection :
        AbstractStructNestedInterfaceCollection<ReadOnlyStructNestedInterface, IPartialInterface>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructNestedInterface> interfaces;

        public ReadOnlyStructNestedInterfaceCollection(StructBody classBody)
        {
            interfaces = classBody.NestedInterfaces.ToArray(@interface => new ReadOnlyStructNestedInterface(@interface));
        }

        public override IReadOnlyCollection<IPartialInterface> PartialInterfaces
        {
            get { return new IPartialInterface[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructNestedInterface> Interfaces
        {
            get { return interfaces; }
        }
    }
}
