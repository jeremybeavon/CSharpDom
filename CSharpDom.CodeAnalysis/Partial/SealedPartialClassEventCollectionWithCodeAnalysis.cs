using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassEventCollectionWithCodeAnalysis :
        EditableSealedClassEventCollection<
            SealedPartialClassEventWithCodeAnalysis,
            SealedPartialClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly SealedClassEventCollectionWithCodeAnalysis eventCollection;
        private readonly WrappedCollection<
            SealedClassEventWithCodeAnalysis,
            SealedPartialClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            SealedClassEventPropertyWithCodeAnalysis,
            SealedPartialClassEventPropertyWithCodeAnalysis> eventProperties;
        
        internal SealedPartialClassEventCollectionWithCodeAnalysis(
            SealedClassEventCollectionWithCodeAnalysis eventCollection)
        {
            this.eventCollection = eventCollection;
            events = new WrappedCollection<SealedClassEventWithCodeAnalysis, SealedPartialClassEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new SealedPartialClassEventWithCodeAnalysis(parent),
                child => child.Event,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<SealedClassEventPropertyWithCodeAnalysis, SealedPartialClassEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new SealedPartialClassEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => eventCollection.EventProperties = value);
        }
        
        public override ICollection<SealedPartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return eventCollection.ExplicitInterfaceEvents; }
            set { eventCollection.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<SealedPartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
