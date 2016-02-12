using System;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class EventCollection<TEvent, TEventProperty, TType> :
        VisitableNotSupported<IGenericVisitor>,
        IEventCollection
        where TType : ITypeWithReflection
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
