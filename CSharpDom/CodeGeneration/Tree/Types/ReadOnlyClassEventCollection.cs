using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassEventCollection :
        AbstractClassEventCollection<ReadOnlyClassEvent, ReadOnlyClassEvent, ReadOnlyExplicitInterfaceEvent>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassEvent> events;
        private readonly IReadOnlyCollection<ReadOnlyClassEvent> eventProperties;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> explicitInterfaceEvents;

        public ReadOnlyClassEventCollection(ClassBody classBody)
        {
            List<ReadOnlyClassEvent> events = new List<ReadOnlyClassEvent>();
            List<ReadOnlyClassEvent> eventProperties = new List<ReadOnlyClassEvent>();
            this.events = events;
            this.eventProperties = eventProperties;
            InitializeEvents(classBody, events, eventProperties);
            explicitInterfaceEvents = classBody.ExplicitInterfaceEvents.ToArray(@event => new ReadOnlyExplicitInterfaceEvent(@event));
        }

        public override IReadOnlyCollection<ReadOnlyClassEvent> EventProperties
        {
            get { return eventProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassEvent> Events
        {
            get { return events; }
        }

        private void InitializeEvents(ClassBody classBody, List<ReadOnlyClassEvent> events, List<ReadOnlyClassEvent> eventProperties)
        {
            foreach (ClassEvent classEvent in classBody.Events)
            {
                ReadOnlyClassEvent @event = new ReadOnlyClassEvent(classEvent);
                if (classEvent.IsEventProperty)
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
