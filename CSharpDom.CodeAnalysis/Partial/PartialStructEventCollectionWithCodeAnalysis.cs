using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructEventCollectionWithCodeAnalysis :
        EditableStructEventCollection<
            PartialStructEventWithCodeAnalysis,
            PartialStructEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly StructEventCollectionWithCodeAnalysis eventCollection;
        private readonly WrappedCollection<
            StructEventWithCodeAnalysis,
            PartialStructEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            StructEventPropertyWithCodeAnalysis,
            PartialStructEventPropertyWithCodeAnalysis> eventProperties;
        
        internal PartialStructEventCollectionWithCodeAnalysis(
            StructEventCollectionWithCodeAnalysis eventCollection)
        {
            this.eventCollection = eventCollection;
            events = new WrappedCollection<StructEventWithCodeAnalysis, PartialStructEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new PartialStructEventWithCodeAnalysis(parent),
                child => child.Event,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<StructEventPropertyWithCodeAnalysis, PartialStructEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new PartialStructEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => eventCollection.EventProperties = value);
        }
        
        public override ICollection<PartialStructEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return eventCollection.ExplicitInterfaceEvents; }
            set { eventCollection.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<PartialStructEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
