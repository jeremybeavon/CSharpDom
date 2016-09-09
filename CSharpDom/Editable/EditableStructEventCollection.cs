using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IStructEvent
        where TEventProperty : IStructEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        public abstract ICollection<TEventProperty> EventProperties { get; set; }

        public abstract ICollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public abstract ICollection<TEvent> Events { get; set; }

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
            visitor.VisitStructEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
