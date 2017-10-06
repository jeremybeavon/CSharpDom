using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            NestedStaticPartialClassEventWithCodeAnalysis,
            NestedStaticPartialClassEventPropertyWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            NestedStaticClassEventWithCodeAnalysis,
            NestedStaticPartialClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            NestedStaticClassEventPropertyWithCodeAnalysis,
            NestedStaticPartialClassEventPropertyWithCodeAnalysis> eventProperties;

        internal NestedStaticPartialClassEventCollectionWithCodeAnalysis(
            NestedStaticClassEventCollectionWithCodeAnalysis eventCollection)
        {
            events = new WrappedCollection<NestedStaticClassEventWithCodeAnalysis, NestedStaticPartialClassEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new NestedStaticPartialClassEventWithCodeAnalysis(parent),
                child => child.Event,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<NestedStaticClassEventPropertyWithCodeAnalysis, NestedStaticPartialClassEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new NestedStaticPartialClassEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => eventCollection.EventProperties = value);
        }

        public override ICollection<NestedStaticPartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
