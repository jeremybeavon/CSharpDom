using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> :
        IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public abstract ICollection<TAbstractEvent> AbstractEvents { get; set; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + AbstractEvents.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract ICollection<TEventProperty> EventProperties { get; set; }

        public abstract ICollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public abstract ICollection<TEvent> Events { get; set; }

        IReadOnlyCollection<TAbstractEvent> IHasAbstractEvents<TAbstractEvent>.AbstractEvents
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractEvent>(AbstractEvents); }
        }

        IReadOnlyCollection<TEventProperty> IHasEventProperties<TEventProperty>.EventProperties
        {
            get { return new ReadOnlyCollectionWrapper<TEventProperty>(EventProperties); }
        }

        IReadOnlyCollection<TExplicitInterfaceEvent> IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceEvent>(ExplicitInterfaceEvents); }
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
