using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedInterfaceCollectionWrapper : AbstractWrapper<IClassNestedInterfaceCollection>, IClassNestedInterfaceCollectionWrapper
    {
        public ClassNestedInterfaceCollectionWrapper(IClassNestedInterfaceCollection collection)
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

        public IEnumerator<IClassNestedInterfaceWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
