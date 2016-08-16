using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class EventCollection<TEvent, TEventProperty, TType>
        where TType : ITypeWithCodeAnalysis
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
