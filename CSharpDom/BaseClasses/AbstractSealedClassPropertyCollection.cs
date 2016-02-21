using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : ISealedClassProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; }

        protected abstract IReadOnlyCollection<TProperty> Properties { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<TProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
