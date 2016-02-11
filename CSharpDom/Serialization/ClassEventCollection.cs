using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class ClassEventCollection :
        IClassEventCollection<ClassEvent, ClassEventProperty, ExplicitInterfaceEvent>
    {
        public ClassEventCollection()
        {
            Events = new List<ClassEvent>();
            EventProperties = new List<ClassEventProperty>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
        }

        public List<ClassEvent> Events { get; set; }

        public List<ClassEventProperty> EventProperties { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        IReadOnlyCollection<ClassEventProperty> IHasEventProperties<ClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }
        
        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassEventCollectionChildren(this, visitor);
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
