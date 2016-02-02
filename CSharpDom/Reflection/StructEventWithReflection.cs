using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructEventWithReflection :
        AbstractStructEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection>
    {
        private readonly EventWithReflection @event;

        internal StructEventWithReflection(EventWithReflection @event)
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
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { throw new NotImplementedException(); }
        }
    }
}
