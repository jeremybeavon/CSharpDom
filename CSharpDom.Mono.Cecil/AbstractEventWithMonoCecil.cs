using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractEventWithMonoCecil :
        AbstractAbstractEvent<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil>
    {
        private readonly EventWithMonoCecil @event;

        internal AbstractEventWithMonoCecil(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.@event = new EventWithMonoCecil(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return @event.EventType; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.AbstractClassVisibility(); }
        }
    }
}
