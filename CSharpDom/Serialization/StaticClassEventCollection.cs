using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassEventCollection :
        IStaticClassEventCollection<StaticClassEvent, StaticClassEventProperty>
    {
        public StaticClassEventCollection()
        {
            Events = new List<StaticClassEvent>();
            EventProperties = new List<StaticClassEventProperty>();
        }

        public int Count
        {
            get { return Events.Count + EventProperties.Count; }
        }

        public List<StaticClassEvent> Events { get; set; }

        public List<StaticClassEventProperty> EventProperties { get; set; }

        IReadOnlyCollection<StaticClassEventProperty> IHasEventProperties<StaticClassEventProperty>.EventProperties
        {
            get { return EventProperties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassEventCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassEvent> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
