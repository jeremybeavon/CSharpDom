using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassPropertyCollectionWrapper : AbstractWrapper<ISealedClassPropertyCollection>, ISealedClassPropertyCollectionWrapper
    {
        public SealedClassPropertyCollectionWrapper(ISealedClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IExplicitInterfacePropertyWrapper> ExplicitInterfaceProperties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<ISealedClassAutoPropertyWrapper> AutoProperties => throw new NotImplementedException();

        public IReadOnlyCollection<ISealedClassLambdaPropertyWrapper> LambdaProperties => throw new NotImplementedException();

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ISealedClassPropertyWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitSealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
