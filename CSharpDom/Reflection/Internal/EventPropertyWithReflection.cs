using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class EventPropertyWithReflection :
        AbstractEventProperty<
            AttributeWithReflection, 
            ITypeWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasEventInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithReflection eventType;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> addBody;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> removeBody;

        internal EventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(@event));
            eventType = new DelegateReferenceWithReflection(@event.EventHandlerType);
            addBody = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(@event.AddMethod));
            removeBody = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(@event.RemoveMethod));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return eventType; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public EventInfo EventInfo
        {
            get { return @event; }
        }

        public override ILMethodBodyWithReflectionEmit AddBody
        {
            get { return addBody.Value; }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get { return removeBody.Value; }
        }
    }
}
