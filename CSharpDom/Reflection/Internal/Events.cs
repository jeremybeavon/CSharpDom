using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Events
    {
        public Events(ITypeWithReflection declaringType, Type type)
        {
            List<EventWithReflection> events = new List<EventWithReflection>();
            List<EventPropertyWithReflection> eventProperties = new List<EventPropertyWithReflection>();
            foreach (EventInfo eventInfo in type.GetAllEvents())
            {
                if (eventInfo.IsDefined(typeof(CompilerGeneratedAttribute)))
                {
                    events.Add(new EventWithReflection(declaringType, eventInfo));
                }
                else
                {
                    eventProperties.Add(new EventPropertyWithReflection(declaringType, eventInfo));
                }
            }

            EventsWithReflection = events;
            EventPropertiesWithReflection = eventProperties;
        }

        public IReadOnlyCollection<EventWithReflection> EventsWithReflection { get; private set; }

        public IReadOnlyCollection<EventPropertyWithReflection> EventPropertiesWithReflection { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplictInterfaceEventsWithReflection { get; private set; }
    }
}
