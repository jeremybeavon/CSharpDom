using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class EventWithReflection :
        AbstractEvent<AttributeWithReflection, ITypeWithReflection, DelegateReferenceWithReflection>,
        IHasEventInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithReflection eventType;

        internal EventWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(@event));
            eventType = new DelegateReferenceWithReflection(@event.EventHandlerType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return eventType; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
        }
        
        public EventInfo EventInfo
        {
            get { return @event; }
        }
    }
}
