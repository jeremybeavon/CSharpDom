using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class EventPropertyWithMonoCecil :
        AbstractEventProperty<
            AttributeWithMonoCecil, 
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>,
        IHasEventInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly EventInfo @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithMonoCecil eventType;
        private readonly Lazy<Attributes> addAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> addBody;
        private readonly Lazy<Attributes> removeAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> removeBody;

        internal EventPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, EventInfo @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(@event));
            eventType = new DelegateReferenceWithMonoCecil(@event.EventHandlerType);
            addAttributes = new Lazy<Attributes>(() => new Attributes(@event.AddMethod));
            addBody = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(@event.AddMethod));
            removeAttributes = new Lazy<Attributes>(() => new Attributes(@event.RemoveMethod));
            removeBody = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(@event.RemoveMethod));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return eventType; }
        }

        public override string Name
        {
            get { return @event.Name(); }
        }

        public EventInfo EventInfo
        {
            get { return @event; }
        }

        public override ILMethodBodyWithMonoCecilEmit AddBody
        {
            get { return addBody.Value; }
        }

        public override ILMethodBodyWithMonoCecilEmit RemoveBody
        {
            get { return removeBody.Value; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return addAttributes.Value.AttributesWithMonoCecil; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> RemoveAttributes
        {
            get { return removeAttributes.Value.AttributesWithMonoCecil; }
        }
    }
}
