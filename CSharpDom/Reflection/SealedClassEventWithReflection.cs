using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassEventWithReflection :
        AbstractSealedClassEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventWithReflection @event;
        private readonly IInternalTypeWithReflection declaringType;

        internal SealedClassEventWithReflection(IInternalTypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = new EventWithReflection(declaringType, @event);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return @event.EventType; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> FieldAttributes
        {
            get { return new AttributeWithReflection[0]; }
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
