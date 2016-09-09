using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStaticClassEventCollection<TEvent, TEventProperty> :
        IStaticClassEventCollection<TEvent, TEventProperty>
        where TEvent : IStaticClassEvent
        where TEventProperty : IStaticClassEventProperty
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count; }
        }

        public abstract ICollection<TEventProperty> EventProperties { get; set; }

        public abstract ICollection<TEvent> Events { get; set; }

        IReadOnlyCollection<TEventProperty> IHasEventProperties<TEventProperty>.EventProperties
        {
            get { return new ReadOnlyCollectionWrapper<TEventProperty>(EventProperties); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
