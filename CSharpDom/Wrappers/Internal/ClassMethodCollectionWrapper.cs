using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassMethodCollectionWrapper : AbstractWrapper<IClassMethodCollection>, IClassMethodCollectionWrapper
    {
        public ClassMethodCollectionWrapper(IClassMethodCollection methodCollection)
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

        public IEnumerator<IClassMethodWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
         
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
