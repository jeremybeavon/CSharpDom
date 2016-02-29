using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExplicitInterfaceEventWithMonoCecil :
        AbstractExplicitInterfaceEvent<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasEventDefinition
    {
        private readonly EventPropertyWithMonoCecil @event;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfaceEventWithMonoCecil(ITypeWithMonoCecil declaringType, TypeReference interfaceType, EventDefinition @event)
        {
            this.@event = new EventPropertyWithMonoCecil(declaringType, @event);
            explicitInterface = new InterfaceReferenceWithMonoCecil(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override ILMethodBodyWithMonoCecilCil AddBody
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

        public EventDefinition EventDefinition
        {
            get { return @event.EventDefinition; }
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

        public override ILMethodBodyWithMonoCecilCil RemoveBody
        {
            get { return @event.RemoveBody; }
        }
    }
}
