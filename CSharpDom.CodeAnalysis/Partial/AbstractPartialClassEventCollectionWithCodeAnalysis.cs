using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassEventCollectionWithCodeAnalysis :
        EditableAbstractClassEventCollection<
            AbstractPartialClassEventWithCodeAnalysis,
            AbstractPartialClassEventPropertyWithCodeAnalysis,
            AbstractPartialClassAbstractEventWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly AbstractClassEventCollectionWithCodeAnalysis eventCollection;
        private readonly WrappedCollection<
            AbstractClassEventWithCodeAnalysis,
            AbstractPartialClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            AbstractClassEventPropertyWithCodeAnalysis,
            AbstractPartialClassEventPropertyWithCodeAnalysis> eventProperties;
        private readonly WrappedCollection<
            AbstractEventWithCodeAnalysis,
            AbstractPartialClassAbstractEventWithCodeAnalysis> abstractEvents;

        internal AbstractPartialClassEventCollectionWithCodeAnalysis(
            AbstractClassEventCollectionWithCodeAnalysis eventCollection)
        {
            this.eventCollection = eventCollection;
            events = new WrappedCollection<AbstractClassEventWithCodeAnalysis, AbstractPartialClassEventWithCodeAnalysis>(
                eventCollection.Events,
                parent => new AbstractPartialClassEventWithCodeAnalysis(parent),
                child => child.InternalEvent,
                value => eventCollection.Events = value);
            eventProperties = new WrappedCollection<AbstractClassEventPropertyWithCodeAnalysis, AbstractPartialClassEventPropertyWithCodeAnalysis>(
                eventCollection.EventProperties,
                parent => new AbstractPartialClassEventPropertyWithCodeAnalysis(parent),
                child => child.InternalEventProperty,
                value => eventCollection.EventProperties = value);
            abstractEvents = new WrappedCollection<AbstractEventWithCodeAnalysis, AbstractPartialClassAbstractEventWithCodeAnalysis>(
                eventCollection.AbstractEvents,
                parent => new AbstractPartialClassAbstractEventWithCodeAnalysis(parent),
                child => child.InternalEvent,
                value => eventCollection.AbstractEvents = value);
        }

        public override ICollection<AbstractPartialClassAbstractEventWithCodeAnalysis> AbstractEvents
        {
            get { return abstractEvents; }
            set { abstractEvents.Replace(value); }
        }

        public override ICollection<AbstractPartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return eventCollection.ExplicitInterfaceEvents; }
            set { eventCollection.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<AbstractPartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { events.Replace(value); }
        }
    }
}
