using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Events<TEvent, TEventProperty>
    {
        public Events(
            ITypeWithReflection declaringType,
            Type type,
            IEventFactory<TEvent, TEventProperty> eventFactory,
            ISet<MethodInfo> interfaceMethods)
        {
            List<TEvent> events = new List<TEvent>();
            List<ExplicitInterfaceEventWithReflection> explicitInterfaceEvents = new List<ExplicitInterfaceEventWithReflection>();
            List<TEventProperty> eventProperties = new List<TEventProperty>();
            foreach (EventInfo eventInfo in type.GetAllEvents())
            {
                if (eventInfo.IsDefined(typeof(CompilerGeneratedAttribute)))
                {
                    events.Add(eventFactory.CreateEvent(declaringType, eventInfo));
                }
                else if (interfaceMethods.Contains(eventInfo.AddMethod) && eventInfo.AddMethod.IsPrivate)
                {
                    explicitInterfaceEvents.Add(new ExplicitInterfaceEventWithReflection(declaringType, eventInfo));
                }
                else
                {
                    eventProperties.Add(eventFactory.CreateEventProperty(declaringType, eventInfo));
                }
            }

            EventsWithReflection = events;
            EventPropertiesWithReflection = eventProperties;
        }

        public IReadOnlyCollection<TEvent> EventsWithReflection { get; private set; }

        public IReadOnlyCollection<TEventProperty> EventPropertiesWithReflection { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplictInterfaceEventsWithReflection { get; private set; }
    }
}
