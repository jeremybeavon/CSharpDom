using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassEventPropertyWithMonoCecil :
        AbstractSealedClassEventProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>
    {
        private readonly EventPropertyWithMonoCecil @event;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal SealedClassEventPropertyWithMonoCecil(IInternalTypeWithMonoCecil declaringType, EventInfo @event)
        {
            this.@event = new EventPropertyWithMonoCecil(declaringType, @event);
            this.declaringType = declaringType;
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

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return @event.EventType; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventInfo.SealedClassInheritanceModifier(declaringType); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ILMethodBodyWithMonoCecilEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventInfo.AddMethod.ClassVisibility(); }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }
    }
}
