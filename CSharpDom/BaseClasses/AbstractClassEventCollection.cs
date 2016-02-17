using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }

        protected abstract IReadOnlyCollection<TEvent> Events { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassEventCollectionChildren(this, visitor);
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
