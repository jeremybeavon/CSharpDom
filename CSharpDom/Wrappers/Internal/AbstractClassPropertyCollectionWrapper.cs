using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractClassPropertyCollectionWrapper : AbstractWrapper<IAbstractClassPropertyCollection>,
        IAbstractClassPropertyCollectionWrapper
    {
        public AbstractClassPropertyCollectionWrapper(IAbstractClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public IReadOnlyCollection<IAbstractPropertyWrapper> AbstractProperties
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

        public IEnumerator<IClassPropertyWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
