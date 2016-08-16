using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassEventWithCodeAnalysis :
        AbstractStaticClassEvent<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>
    {
        private readonly EventWithCodeAnalysis @event;

        internal StaticClassEventWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
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

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> FieldAttributes
        {
            get { return new AttributeGroupWithCodeAnalysis[0]; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.StaticClassVisibility(); }
        }
    }
}
