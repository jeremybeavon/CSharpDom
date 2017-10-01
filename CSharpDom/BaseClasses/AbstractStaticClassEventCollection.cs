using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassEventCollection<TEvent, TEventProperty> :
        AbstractGenericVisitableObject,
        IStaticClassEventCollection<TEvent, TEventProperty>
        where TEvent : IStaticClassEvent
        where TEventProperty : IStaticClassEventProperty
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count; }
        }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        protected abstract IReadOnlyCollection<TEvent> Events { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassEventCollectionChildren(this, visitor);
        }

        public IEnumerator<TEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
