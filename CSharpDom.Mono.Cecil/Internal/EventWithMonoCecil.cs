using CSharpDom.BaseClasses;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class EventWithMonoCecil :
        AbstractEvent<AttributeWithMonoCecil, ITypeWithMonoCecil, DelegateReferenceWithMonoCecil>,
        IHasEventDefinition
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(CompilerGeneratedAttribute),
            typeof(DebuggerBrowsableAttribute)
        };
        private readonly ITypeWithMonoCecil declaringType;
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithMonoCecil eventType;

        internal EventWithMonoCecil(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event, excludedAttributeTypes));
            eventType = new DelegateReferenceWithMonoCecil(declaringType.Assembly, @event.EventType);
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
        
        public EventDefinition EventDefinition
        {
            get { return @event; }
        }
    }
}
