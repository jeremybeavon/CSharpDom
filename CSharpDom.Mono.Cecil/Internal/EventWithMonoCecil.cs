using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class EventWithMonoCecil :
        AbstractEvent<AttributeWithMonoCecil, ITypeWithMonoCecil, DelegateReferenceWithMonoCecil>,
        IHasEventInfo
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(CompilerGeneratedAttribute),
            typeof(DebuggerBrowsableAttribute)
        };
        private readonly ITypeWithMonoCecil declaringType;
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithMonoCecil eventType;

        internal EventWithMonoCecil(ITypeWithMonoCecil declaringType, EventInfo @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(@event, excludedAttributeTypes));
            eventType = new DelegateReferenceWithMonoCecil(@event.EventHandlerType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
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
