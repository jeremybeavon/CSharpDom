using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        AbstractGenericVisitableObject,
        ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : ISealedClassEvent
        where TEventProperty : ISealedClassEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }

        protected abstract IReadOnlyCollection<TEvent> Events { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEventCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassEventCollectionChildren(this, visitor);
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
