using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructMethodCollectionWrapper : AbstractWrapper<IStructMethodCollection>, IStructMethodCollectionWrapper
    {
        public StructMethodCollectionWrapper(IStructMethodCollection methodCollection)
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

        public IEnumerator<IStructMethodWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
