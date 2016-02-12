using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructEventCollection :
        AbstractStructEventCollection<ReadOnlyStructEvent, ReadOnlyStructEvent, ReadOnlyExplicitInterfaceEvent>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructEvent> events;
        private readonly IReadOnlyCollection<ReadOnlyStructEvent> eventProperties;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> explicitInterfaceEvents;

        public ReadOnlyStructEventCollection(StructBody structBody)
        {
            List<ReadOnlyStructEvent> events = new List<ReadOnlyStructEvent>();
            List<ReadOnlyStructEvent> eventProperties = new List<ReadOnlyStructEvent>();
            this.events = events;
            this.eventProperties = eventProperties;
            InitializeEvents(structBody, events, eventProperties);
            explicitInterfaceEvents = structBody.ExplicitInterfaceEvents.ToArray(@event => new ReadOnlyExplicitInterfaceEvent(@event));
        }

        public override IReadOnlyCollection<ReadOnlyStructEvent> EventProperties
        {
            get { return eventProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructEvent> Events
        {
            get { return events; }
        }

        private void InitializeEvents(StructBody structBody, List<ReadOnlyStructEvent> events, List<ReadOnlyStructEvent> eventProperties)
        {
            foreach (StructEvent structEvent in structBody.Events)
            {
                ReadOnlyStructEvent @event = new ReadOnlyStructEvent(structEvent);
                if (structEvent.IsEventProperty)
                {
                    eventProperties.Add(@event);
                }
                else
                {
                    events.Add(@event);
                }
            }
        }
    }
}
