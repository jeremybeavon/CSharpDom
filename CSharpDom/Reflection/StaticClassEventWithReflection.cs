using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassEventWithReflection :
        AbstractStaticClassEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventWithReflection @event;

        internal StaticClassEventWithReflection(ITypeWithReflection declaringType, EventInfo @event)
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
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override StaticClassMemberVisibilityModifier InheritanceModifier
        {
            get { return @event.EventInfo.AddMethod.StaticClassVisibility(); }
        }
    }
}
