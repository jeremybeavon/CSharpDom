using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceEventWithReflection :
        AbstractInterfaceEvent<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly IBasicTypeWithReflection declaringType;
        private readonly DelegateReferenceWithReflection eventType;

        internal InterfaceEventWithReflection(IBasicTypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = @event;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(@event));
            eventType = new DelegateReferenceWithReflection(@event.EventHandlerType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return eventType; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if (@event.AddMethod.IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return @event.Name; }
        }
    }
}
