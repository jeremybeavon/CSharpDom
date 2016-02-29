using Mono.Cecil;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Events<TEvent, TEventProperty, TType>
        where TType : ITypeWithMonoCecil
    {
        public Events(
            TType declaringType,
            IEventFactory<TEvent, TEventProperty, TType> eventFactory,
            IDictionary<MethodDefinition, TypeDefinition> interfaceMethods)
        {
            List<TEvent> events = new List<TEvent>();
            List<ExplicitInterfaceEventWithMonoCecil> explicitInterfaceEvents = new List<ExplicitInterfaceEventWithMonoCecil>();
            List<TEventProperty> eventProperties = new List<TEventProperty>();
            List<AbstractEventWithMonoCecil> abstractEvents = new List<AbstractEventWithMonoCecil>();
            foreach (EventDefinition eventDefinition in declaringType.TypeDefinition.Events)
            {
                TypeDefinition interfaceType;
                if (eventDefinition.AddMethod.IsDefined(declaringType.Assembly, typeof(CompilerGeneratedAttribute)))
                {
                    events.Add(eventFactory.CreateEvent(declaringType, eventDefinition));
                }
                else if (interfaceMethods.TryGetValue(eventDefinition.AddMethod, out interfaceType))
                {
                    explicitInterfaceEvents.Add(new ExplicitInterfaceEventWithMonoCecil(declaringType, interfaceType, eventDefinition));
                }
                else if (eventDefinition.AddMethod.IsAbstract)
                {
                    abstractEvents.Add(new AbstractEventWithMonoCecil(declaringType, eventDefinition));
                }
                else
                {
                    eventProperties.Add(eventFactory.CreateEventProperty(declaringType, eventDefinition));
                }
            }

            EventsWithMonoCecil = events;
            EventPropertiesWithMonoCecil = eventProperties;
            ExplictInterfaceEventsWithMonoCecil = explicitInterfaceEvents;
            AbstractEventsWithMonoCecil = abstractEvents;
        }

        public IReadOnlyCollection<TEvent> EventsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<TEventProperty> EventPropertiesWithMonoCecil { get; private set; }

        public IReadOnlyCollection<AbstractEventWithMonoCecil> AbstractEventsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceEventWithMonoCecil> ExplictInterfaceEventsWithMonoCecil { get; private set; }
    }
}
