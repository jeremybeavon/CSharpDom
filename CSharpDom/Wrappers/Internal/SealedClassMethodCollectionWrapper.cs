using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassMethodCollectionWrapper : AbstractWrapper<ISealedClassMethodCollection>, ISealedClassMethodCollectionWrapper
    {
        public SealedClassMethodCollectionWrapper(ISealedClassMethodCollection methodCollection)
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

        public IReadOnlyCollection<IExplicitInterfaceMethodWrapper> ExplicitInterfaceMethods
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

        public IEnumerator<ISealedClassMethodWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
