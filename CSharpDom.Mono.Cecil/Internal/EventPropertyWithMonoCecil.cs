using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class EventPropertyWithMonoCecil :
        AbstractEventProperty<
            AttributeWithMonoCecil, 
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasEventDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithMonoCecil eventType;
        private readonly Lazy<Attributes> addAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> addBody;
        private readonly Lazy<Attributes> removeAttributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> removeBody;

        internal EventPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event));
            eventType = new DelegateReferenceWithMonoCecil(declaringType.Assembly, @event.EventType);
            addAttributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event.AddMethod));
            addBody = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(@event.AddMethod));
            removeAttributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event.RemoveMethod));
            removeBody = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(@event.RemoveMethod));
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
            get { return @event.Name; }
        }

        public EventDefinition EventDefinition
        {
            get { return @event; }
        }

        public override ILMethodBodyWithMonoCecilCil AddBody
        {
            get { return addBody.Value; }
        }

        public override ILMethodBodyWithMonoCecilCil RemoveBody
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
