using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructPropertyCollection<TProperty, TAutoProperties, TLambdaProperties, TExplicitInterfaceProperty> :
        AbstractGenericVisitableObject,
        IStructPropertyCollection<TProperty, TAutoProperties, TLambdaProperties, TExplicitInterfaceProperty>
        where TProperty : IStructProperty
        where TAutoProperties : IStructAutoProperty
        where TLambdaProperties : IStructLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract IReadOnlyCollection<TAutoProperties> AutoProperties { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; }
        
        public abstract IReadOnlyCollection<TLambdaProperties> LambdaProperties { get; }

        protected abstract IReadOnlyCollection<TProperty> Properties { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructPropertyCollectionChildren(this, visitor);
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
