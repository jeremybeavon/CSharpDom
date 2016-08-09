using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassEventWithMonoCecil :
        AbstractStaticClassEvent<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil>
    {
        private readonly EventWithMonoCecil @event;

        internal StaticClassEventWithMonoCecil(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.@event = new EventWithMonoCecil(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return @event.EventType; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> FieldAttributes
        {
            get { return new AttributeWithMonoCecil[0]; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.StaticClassVisibility(); }
        }
    }
}
