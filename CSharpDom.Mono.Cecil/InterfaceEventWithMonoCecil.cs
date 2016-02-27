using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceEventWithMonoCecil :
        AbstractInterfaceEvent<
            AttributeWithMonoCecil,
            IBasicTypeWithMonoCecil,
            DelegateReferenceWithMonoCecil>
    {
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly IBasicTypeWithMonoCecil declaringType;
        private readonly DelegateReferenceWithMonoCecil eventType;

        internal InterfaceEventWithMonoCecil(IBasicTypeWithMonoCecil declaringType, EventInfo @event)
        {
            this.@event = @event;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(@event));
            eventType = new DelegateReferenceWithMonoCecil(@event.EventHandlerType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IBasicTypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
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
