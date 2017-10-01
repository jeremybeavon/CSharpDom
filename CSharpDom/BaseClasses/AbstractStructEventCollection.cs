using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        AbstractGenericVisitableObject,
        IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IStructEvent
        where TEventProperty : IStructEventProperty
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
            visitor.VisitStructEventCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructEventCollectionChildren(this, visitor);
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
