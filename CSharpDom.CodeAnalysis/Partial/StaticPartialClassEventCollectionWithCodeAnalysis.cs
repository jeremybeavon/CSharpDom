using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticPartialClassEventWithCodeAnalysis,
            StaticPartialClassEventPropertyWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StaticClassEventWithCodeAnalysis,
            StaticPartialClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            StaticClassEventPropertyWithCodeAnalysis,
            StaticPartialClassEventPropertyWithCodeAnalysis> eventProperties;

        internal StaticPartialClassEventCollectionWithCodeAnalysis(
            StaticClassEventCollectionWithCodeAnalysis eventCollection)
        {
            events = new WrappedCollection<StaticClassEventWithCodeAnalysis, StaticPartialClassEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new StaticPartialClassEventWithCodeAnalysis(parent),
                child => child.Event,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<StaticClassEventPropertyWithCodeAnalysis, StaticPartialClassEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new StaticPartialClassEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => eventCollection.EventProperties = value);
        }

        public override ICollection<StaticPartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<StaticPartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
