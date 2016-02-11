using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class StructEventCollection :
        IStructEventCollection<StructEvent, StructEventProperty, ExplicitInterfaceEvent>
    {
        public StructEventCollection()
        {
            Events = new List<StructEvent>();
            EventProperties = new List<StructEventProperty>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
        }

        public List<StructEvent> Events { get; set; }

        public List<StructEventProperty> EventProperties { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        IReadOnlyCollection<StructEventProperty> IHasEventProperties<StructEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }
        
        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructEventCollectionChildren(this, visitor);
        }

        public IEnumerator<StructEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
