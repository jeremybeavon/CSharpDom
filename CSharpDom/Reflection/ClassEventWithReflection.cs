using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassEventWithReflection :
        AbstractClassEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventWithReflection @event;

        internal ClassEventWithReflection(EventWithReflection @event)
        {
            this.@event = @event;
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
            get { throw new NotImplementedException(); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { throw new NotImplementedException(); }
        }
    }
}
