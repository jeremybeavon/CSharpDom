using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticClassEventCollection<TEvent, TEventProperty> :
        AbstractGenericVisitableObject,
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
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
