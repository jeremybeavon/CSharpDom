using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> :
        AbstractGenericVisitableObject,
        IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public abstract IReadOnlyCollection<TAbstractEvent> AbstractEvents { get; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + AbstractEvents.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }

        protected abstract IReadOnlyCollection<TEvent> Events { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassEventCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassEventCollectionChildren(this, visitor);
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
