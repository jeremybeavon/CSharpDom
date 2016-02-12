using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedInterfaceCollection :
        AbstractClassNestedInterfaceCollection<ReadOnlyClassNestedInterface, IPartialInterface>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassNestedInterface> interfaces;

        public ReadOnlyClassNestedInterfaceCollection(ClassBody classBody)
        {
            interfaces = classBody.NestedInterfaces.ToArray(@interface => new ReadOnlyClassNestedInterface(@interface));
        }

        public override IReadOnlyCollection<IPartialInterface> PartialInterfaces
        {
            get { return new IPartialInterface[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassNestedInterface> Interfaces
        {
            get { return interfaces; }
        }
    }
}
