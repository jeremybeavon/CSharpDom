using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IStructEvent
        where TEventProperty : IStructEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        public virtual IReadOnlyCollection<TEventProperty> EventProperties { get; set; }

        public virtual IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        protected virtual IReadOnlyCollection<TEvent> Events { get; set; }

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
