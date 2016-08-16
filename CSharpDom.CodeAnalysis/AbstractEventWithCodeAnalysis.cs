using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractEventWithCodeAnalysis :
        AbstractAbstractEvent<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>
    {
        private readonly EventWithCodeAnalysis @event;

        internal AbstractEventWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.@event = new EventWithCodeAnalysis(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.ClassVisibility(); }
        }
    }
}
