using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfaceEventWithReflection :
        AbstractExplicitInterfaceEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasEventInfo
    {
        private readonly EventPropertyWithReflection @event;

        internal ExplicitInterfaceEventWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = new EventPropertyWithReflection(declaringType, @event);
        }

        public override ILMethodBodyWithReflectionEmit AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public EventInfo EventInfo
        {
            get { return @event.EventInfo; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return @event.EventType; }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }
    }
}
