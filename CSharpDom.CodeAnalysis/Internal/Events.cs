using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Events<TEvent, TEventProperty, TType>
        where TType : ITypeWithCodeAnalysis
    {
        public Events(
            TType declaringType,
            IEventFactory<TEvent, TEventProperty, TType> eventFactory)
        {
            List<TEvent> events = new List<TEvent>();
            List<ExplicitInterfaceEventWithCodeAnalysis> explicitInterfaceEvents = new List<ExplicitInterfaceEventWithCodeAnalysis>();
            List<TEventProperty> eventProperties = new List<TEventProperty>();
            List<AbstractEventWithCodeAnalysis> abstractEvents = new List<AbstractEventWithCodeAnalysis>();
            foreach (EventDefinition eventDefinition in declaringType.TypeDefinition.Events)
            {
                if (eventDefinition.AddMethod.IsDefined(declaringType.Assembly, typeof(CompilerGeneratedAttribute)))
                {
                    events.Add(eventFactory.CreateEvent(declaringType, eventDefinition));
                }
                else if (eventDefinition.Name.Contains("."))
                {
                    explicitInterfaceEvents.Add(new ExplicitInterfaceEventWithCodeAnalysis(declaringType, eventDefinition));
                }
                else if (eventDefinition.AddMethod.IsAbstract)
                {
                    abstractEvents.Add(new AbstractEventWithCodeAnalysis(declaringType, eventDefinition));
                }
                else
                {
                    eventProperties.Add(eventFactory.CreateEventProperty(declaringType, eventDefinition));
                }
            }

            EventsWithCodeAnalysis = events;
            EventPropertiesWithCodeAnalysis = eventProperties;
            ExplictInterfaceEventsWithCodeAnalysis = explicitInterfaceEvents;
            AbstractEventsWithCodeAnalysis = abstractEvents;
        }

        public IReadOnlyCollection<TEvent> EventsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<TEventProperty> EventPropertiesWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<AbstractEventWithCodeAnalysis> AbstractEventsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceEventWithCodeAnalysis> ExplictInterfaceEventsWithCodeAnalysis { get; private set; }
    }
}
