using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class EventPropertyWithReflection :
        AbstractEventProperty<AttributeWithReflection, ITypeWithReflection, DelegateReferenceWithReflection>,
        IHasEventInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithReflection eventType;

        internal EventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
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

        public override MemberInheritanceModifier InheritanceModifier
        {
            get { return @event.AddMethod.InheritanceModifier(); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return @event.AddMethod.Visibility(); }
        }

        public EventInfo EventInfo
        {
            get { return @event; }
        }
    }
}
