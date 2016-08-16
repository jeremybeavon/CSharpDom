using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> :
        IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public virtual Collection<TAbstractEvent> AbstractEvents { get; set; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + AbstractEvents.Count + ExplicitInterfaceEvents.Count; }
        }

        public virtual Collection<TEventProperty> EventProperties { get; set; }

        public virtual Collection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        protected virtual Collection<TEvent> Events { get; set; }

        IReadOnlyCollection<TAbstractEvent> IHasAbstractEvents<TAbstractEvent>.AbstractEvents
        {
            get { return AbstractEvents; }
        }

        IReadOnlyCollection<TEventProperty> IHasEventProperties<TEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<TExplicitInterfaceEvent> IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
