using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty> :
        AbstractGenericVisitableObject,
        IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>
        where TProperty : IStaticClassProperty
        where TAutoProperty : IStaticClassAutoProperty
        where TLambdaProperty : IStaticClassLambdaProperty
    {
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count; }
        }

        public abstract IReadOnlyCollection<TAutoProperty> AutoProperties { get; }

        public abstract IReadOnlyCollection<TLambdaProperty> LambdaProperties { get; }

        protected abstract IReadOnlyCollection<TProperty> Properties { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassPropertyCollectionChildren(this, visitor);
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
