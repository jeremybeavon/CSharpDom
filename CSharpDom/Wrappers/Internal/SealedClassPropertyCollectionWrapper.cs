using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassPropertyCollectionWrapper : AbstractWrapper<ISealedClassPropertyCollection>, ISealedClassPropertyCollectionWrapper
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

        public override void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
