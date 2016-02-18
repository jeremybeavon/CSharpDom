using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Events<TEvent, TEventProperty, TType>
        where TType : ITypeWithReflection
    {
        public Events(
            TType declaringType,
            IEventFactory<TEvent, TEventProperty, TType> eventFactory,
            IDictionary<MethodInfo, Type> interfaceMethods)
        {
            List<TEvent> events = new List<TEvent>();
            List<ExplicitInterfaceEventWithReflection> explicitInterfaceEvents = new List<ExplicitInterfaceEventWithReflection>();
            List<TEventProperty> eventProperties = new List<TEventProperty>();
            List<AbstractEventWithReflection> abstractEvents = new List<AbstractEventWithReflection>();
            foreach (EventInfo eventInfo in declaringType.Type.GetAllEvents())
            {
                Type interfaceType;
                if (eventInfo.AddMethod.IsDefined(typeof(CompilerGeneratedAttribute), false))
                {
                    events.Add(eventFactory.CreateEvent(declaringType, eventInfo));
                }
                else if (interfaceMethods.TryGetValue(eventInfo.AddMethod, out interfaceType))
                {
                    explicitInterfaceEvents.Add(new ExplicitInterfaceEventWithReflection(declaringType, interfaceType, eventInfo));
                }
                else if (eventInfo.AddMethod.IsAbstract)
                {
                    abstractEvents.Add(new AbstractEventWithReflection(declaringType, eventInfo));
                }
                else
                {
                    eventProperties.Add(eventFactory.CreateEventProperty(declaringType, eventInfo));
                }
            }

            EventsWithReflection = events;
            EventPropertiesWithReflection = eventProperties;
            ExplictInterfaceEventsWithReflection = explicitInterfaceEvents;
            AbstractEventsWithReflection = abstractEvents;
        }

        public IReadOnlyCollection<TEvent> EventsWithReflection { get; private set; }

        public IReadOnlyCollection<TEventProperty> EventPropertiesWithReflection { get; private set; }

        public IReadOnlyCollection<AbstractEventWithReflection> AbstractEventsWithReflection { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplictInterfaceEventsWithReflection { get; private set; }
    }
}
