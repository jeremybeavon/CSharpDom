using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Events<TEvent, TEventProperty, TType>
        where TType : ITypeWithMonoCecil
    {
        public Events(
            TType declaringType,
            IEventFactory<TEvent, TEventProperty, TType> eventFactory,
            IDictionary<MethodInfo, Type> interfaceMethods)
        {
            List<TEvent> events = new List<TEvent>();
            List<ExplicitInterfaceEventWithMonoCecil> explicitInterfaceEvents = new List<ExplicitInterfaceEventWithMonoCecil>();
            List<TEventProperty> eventProperties = new List<TEventProperty>();
            List<AbstractEventWithMonoCecil> abstractEvents = new List<AbstractEventWithMonoCecil>();
            foreach (EventInfo eventInfo in declaringType.Type.GetAllEvents())
            {
                Type interfaceType;
                if (eventInfo.AddMethod.IsDefined(typeof(CompilerGeneratedAttribute), false))
                {
                    events.Add(eventFactory.CreateEvent(declaringType, eventInfo));
                }
                else if (interfaceMethods.TryGetValue(eventInfo.AddMethod, out interfaceType))
                {
                    explicitInterfaceEvents.Add(new ExplicitInterfaceEventWithMonoCecil(declaringType, interfaceType, eventInfo));
                }
                else if (eventInfo.AddMethod.IsAbstract)
                {
                    abstractEvents.Add(new AbstractEventWithMonoCecil(declaringType, eventInfo));
                }
                else
                {
                    eventProperties.Add(eventFactory.CreateEventProperty(declaringType, eventInfo));
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
