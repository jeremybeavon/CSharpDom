using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedStaticClassMethodCollectionWrapper : AbstractWrapper<INestedStaticClassMethodCollection>,
        INestedStaticClassMethodCollectionWrapper
    {
        public NestedStaticClassMethodCollectionWrapper(INestedStaticClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public int Count
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

        public IEnumerator<IStaticClassMethodWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitNestedStaticClassMethodCollection<TMethod>(
            INestedStaticClassMethodCollection<TMethod> methodCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
