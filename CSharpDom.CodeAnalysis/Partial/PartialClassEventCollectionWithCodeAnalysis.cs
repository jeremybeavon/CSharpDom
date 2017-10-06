using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassEventCollectionWithCodeAnalysis :
        EditableClassEventCollection<
            PartialClassEventWithCodeAnalysis,
            PartialClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassEventCollectionWithCodeAnalysis eventCollection;
        private readonly WrappedCollection<
            ClassEventWithCodeAnalysis,
            PartialClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            ClassEventPropertyWithCodeAnalysis,
            PartialClassEventPropertyWithCodeAnalysis> eventProperties;
        
        internal PartialClassEventCollectionWithCodeAnalysis(
            ClassEventCollectionWithCodeAnalysis eventCollection)
        {
            this.eventCollection = eventCollection;
            events = new WrappedCollection<ClassEventWithCodeAnalysis, PartialClassEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new PartialClassEventWithCodeAnalysis(parent),
                child => child.Event,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<ClassEventPropertyWithCodeAnalysis, PartialClassEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new PartialClassEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => eventCollection.EventProperties = value);
        }
        
        public override ICollection<PartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return eventCollection.ExplicitInterfaceEvents; }
            set { eventCollection.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<PartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
