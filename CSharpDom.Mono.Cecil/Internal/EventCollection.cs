using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class EventCollection<TEvent, TEventProperty, TType>
        where TType : ITypeWithMonoCecil
    {
        private readonly Lazy<Events<TEvent, TEventProperty, TType>> events;

        public EventCollection(Func<Events<TEvent, TEventProperty, TType>> events)
        {
            this.events = new Lazy<Events<TEvent, TEventProperty, TType>>(events);
        }

        public Events<TEvent, TEventProperty, TType> Events
        {
            get { return events.Value; }
        }
    }
}
