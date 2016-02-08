using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class EventSignature : AbstractEvent<AttributeGroupNotSupported, IBasicType, DelegateReferenceWithReflection>
    {
        private readonly DelegateReferenceWithReflection eventType;
        private readonly EventInfo @event;

        public EventSignature(EventInfo @event)
        {
            this.@event = @event;
            eventType = new DelegateReferenceWithReflection(@event.EventHandlerType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return eventType; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }
    }
}
