using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedInterfaceCollectionWrapper<TInterface, TPartialInterface> :
        AbstractNestedInterfaceCollection<TInterface, TPartialInterface>,
        IWrapper<INestedInterfaceCollection<TInterface, TPartialInterface>>
        where TInterface : INestedInterface
        where TPartialInterface : IPartialInterface
    {
        public NestedInterfaceCollectionWrapper(
            INestedInterfaceCollection<TInterface, TPartialInterface> nestedInterfaceCollection)
        {
            WrappedObject = nestedInterfaceCollection;
        }

        public override IReadOnlyCollection<TPartialInterface> PartialInterfaces
        {
            get { return WrappedObject.PartialInterfaces; }
        }

        public INestedInterfaceCollection<TInterface, TPartialInterface> WrappedObject { get; private set; }

        protected override IReadOnlyCollection<TInterface> Interfaces
        {
            get { return WrappedObject; }
        }
    }
}
