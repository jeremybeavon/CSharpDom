using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClassEventCollection :
        IAbstractClassEventCollection<ClassEvent, ClassEventProperty, AbstractEvent, ExplicitInterfaceEvent>
    {
        public AbstractClassEventCollection()
        {
            AbstractEvents = new List<AbstractEvent>();
            Events = new List<ClassEvent>();
            EventProperties = new List<ClassEventProperty>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
        }

        public List<AbstractEvent> AbstractEvents { get; set; }

        public List<ClassEvent> Events { get; set; }

        public List<ClassEventProperty> EventProperties { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public int Count
        {
            get { return AbstractEvents.Count + Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        IReadOnlyCollection<ClassEventProperty> IHasEventProperties<ClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        IReadOnlyCollection<AbstractEvent> IHasAbstractEvents<AbstractEvent>.AbstractEvents
        {
            get { return AbstractEvents; }
        }

        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
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

        public IEnumerator<ClassEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
