using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractClassMethodCollectionWrapper : AbstractWrapper<IAbstractClassMethodCollection>,
        IAbstractClassMethodCollectionWrapper
    {
        public AbstractClassMethodCollectionWrapper(IAbstractClassMethodCollection methodCollection)
            : base(methodCollection)
        {
        }

        public IReadOnlyCollection<IAbstractMethodWrapper> AbstractMethods
        {
            get
            {
                throw new NotImplementedException();
            }
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

        public override void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
