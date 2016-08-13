using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedInterfaceCollectionWrapper : AbstractWrapper<IStaticClassNestedInterfaceCollection>,
        IStaticClassNestedInterfaceCollectionWrapper
    {
        public StaticClassNestedInterfaceCollectionWrapper(IStaticClassNestedInterfaceCollection collection)
            : base(collection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IPartialInterface> PartialInterfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IStaticClassNestedInterfaceWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
