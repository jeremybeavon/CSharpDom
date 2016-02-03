using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassEventWithReflection :
        AbstractClassEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventWithReflection @event;

        internal ClassEventWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = new EventWithReflection(declaringType, @event);
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
            get { throw new NotImplementedException(); }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventInfo.AddMethod.InheritanceModifier(); }
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
