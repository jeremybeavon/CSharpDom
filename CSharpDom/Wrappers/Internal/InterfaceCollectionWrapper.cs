using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceCollectionWrapper : AbstractWrapper<IInterfaceCollection>, IInterfaceCollectionWrapper
    {
        public InterfaceCollectionWrapper(IInterfaceCollection field)
            : base(field)
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

        public IEnumerator<IInterfaceWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitInterfaceCollection<TInterface, TPartialInterface>(
            IInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
