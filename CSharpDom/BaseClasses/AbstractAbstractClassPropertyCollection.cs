using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TAbstractProperty,
        TExplicitInterfaceProperty> :
        AbstractGenericVisitableObject,
        IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAutoProperty : IClassAutoProperty
        where TLambdaProperty : IClassLambdaProperty
        where TAbstractProperty : IAbstractProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public abstract IReadOnlyCollection<TAbstractProperty> AbstractProperties { get; }

        public int Count
        {
            get
            {
                return Properties.Count +
                    AutoProperties.Count +
                    LambdaProperties.Count +
                    AbstractProperties.Count +
                    ExplicitInterfaceProperties.Count;
            }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; }

        public abstract IReadOnlyCollection<TAutoProperty> AutoProperties { get; }

        public abstract IReadOnlyCollection<TLambdaProperty> LambdaProperties { get; }

        protected abstract IReadOnlyCollection<TProperty> Properties { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassPropertyCollectionChildren(this, visitor);
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
