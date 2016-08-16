using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class EventPropertyWithCodeAnalysis :
        AbstractEventProperty<
            AttributeGroupWithCodeAnalysis, 
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasEventDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithCodeAnalysis eventType;
        private readonly Lazy<Attributes> addAttributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> addBody;
        private readonly Lazy<Attributes> removeAttributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> removeBody;

        internal EventPropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event));
            eventType = new DelegateReferenceWithCodeAnalysis(declaringType.Assembly, @event.EventType);
            addAttributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event.AddMethod));
            addBody = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(@event.AddMethod));
            removeAttributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event.RemoveMethod));
            removeBody = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(@event.RemoveMethod));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
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

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return addBody.Value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return removeBody.Value; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return addAttributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return removeAttributes.Value.AttributesWithCodeAnalysis; }
        }
    }
}
