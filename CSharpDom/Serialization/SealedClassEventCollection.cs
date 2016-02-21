using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassEventCollection :
        ISealedClassEventCollection<SealedClassEvent, SealedClassEventProperty, ExplicitInterfaceEvent>
    {
        public SealedClassEventCollection()
        {
            Events = new List<SealedClassEvent>();
            EventProperties = new List<SealedClassEventProperty>();
            ExplicitInterfaceEvents = new List<ExplicitInterfaceEvent>();
        }
        
        public List<SealedClassEvent> Events { get; set; }

        public List<SealedClassEventProperty> EventProperties { get; set; }

        public List<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public int Count
        {
            get { return Events.Count + EventProperties.Count + ExplicitInterfaceEvents.Count; }
        }

        IReadOnlyCollection<SealedClassEventProperty> IHasEventProperties<SealedClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }
        
        IReadOnlyCollection<ExplicitInterfaceEvent> IHasExplicitInterfaceEvents<ExplicitInterfaceEvent>.ExplicitInterfaceEvents
        {
            get { return ExplicitInterfaceEvents; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassEventCollectionChildren(this, visitor);
        }

        public IEnumerator<SealedClassEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
