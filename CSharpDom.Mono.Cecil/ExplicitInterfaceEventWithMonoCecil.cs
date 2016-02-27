using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExplicitInterfaceEventWithMonoCecil :
        AbstractExplicitInterfaceEvent<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>,
        IHasEventInfo
    {
        private readonly EventPropertyWithMonoCecil @event;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfaceEventWithMonoCecil(ITypeWithMonoCecil declaringType, Type interfaceType, EventInfo @event)
        {
            this.@event = new EventPropertyWithMonoCecil(declaringType, @event);
            explicitInterface = new InterfaceReferenceWithMonoCecil(interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override ILMethodBodyWithMonoCecilEmit AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public EventInfo EventInfo
        {
            get { return @event.EventInfo; }
        }

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return @event.EventType; }
        }

        public override InterfaceReferenceWithMonoCecil ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }

        public override ILMethodBodyWithMonoCecilEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }
    }
}
