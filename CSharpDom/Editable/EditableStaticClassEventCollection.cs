using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassEventCollection<TEvent, TEventProperty> :
        IStaticClassEventCollection<TEvent, TEventProperty>
        where TEvent : IStaticClassEvent
        where TEventProperty : IStaticClassEventProperty
    {
        public int Count
        {
            get { return Events.Count + EventProperties.Count; }
        }

        public virtual IReadOnlyCollection<TEventProperty> EventProperties { get; set; }

        protected virtual IReadOnlyCollection<TEvent> Events { get; set; }

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
