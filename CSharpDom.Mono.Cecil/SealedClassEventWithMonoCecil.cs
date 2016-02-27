﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassEventWithMonoCecil :
        AbstractSealedClassEvent<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil>
    {
        private readonly EventWithMonoCecil @event;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal SealedClassEventWithMonoCecil(IInternalTypeWithMonoCecil declaringType, EventInfo @event)
        {
            this.@event = new EventWithMonoCecil(declaringType, @event);
            this.declaringType = declaringType;
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
            get { throw new NotImplementedException(); }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventInfo.SealedClassInheritanceModifier(declaringType); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventInfo.AddMethod.ClassVisibility(); }
        }
    }
}
