using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceEventWithMonoCecil :
        AbstractInterfaceEvent<
            AttributeWithMonoCecil,
            IInterfaceTypeWithMonoCecil,
            DelegateReferenceWithMonoCecil>
    {
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly IInterfaceTypeWithMonoCecil declaringType;
        private readonly DelegateReferenceWithMonoCecil eventType;

        internal InterfaceEventWithMonoCecil(IInterfaceTypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.@event = @event;
            this.declaringType = declaringType;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, @event));
            eventType = new DelegateReferenceWithMonoCecil(assembly, @event.EventType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IInterfaceTypeWithMonoCecil DeclaringType
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
