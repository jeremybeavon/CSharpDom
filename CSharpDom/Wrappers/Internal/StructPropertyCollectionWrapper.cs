using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructPropertyCollectionWrapper : AbstractWrapper<IStructPropertyCollection>, IStructPropertyCollectionWrapper
    {
        public StructPropertyCollectionWrapper(IStructPropertyCollection propertyCollection)
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

        public IEnumerator<IStructPropertyWrapper> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
