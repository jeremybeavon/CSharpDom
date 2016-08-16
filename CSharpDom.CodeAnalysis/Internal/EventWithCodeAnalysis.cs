using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class EventWithCodeAnalysis :
        AbstractEvent<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, DelegateReferenceWithCodeAnalysis>,
        IHasEventDefinition
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(CompilerGeneratedAttribute),
            typeof(DebuggerBrowsableAttribute)
        };
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly DelegateReferenceWithCodeAnalysis eventType;

        internal EventWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.declaringType = declaringType;
            this.@event = @event;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, @event, excludedAttributeTypes));
            eventType = new DelegateReferenceWithCodeAnalysis(declaringType.Assembly, @event.EventType);
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
    }
}
