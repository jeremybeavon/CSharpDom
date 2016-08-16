using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructEventWithCodeAnalysis :
        AbstractStructEvent<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>
    {
        private readonly EventWithCodeAnalysis @event;

        internal StructEventWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
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

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventDefinition.AddMethod.IsStatic ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.StructVisibility(); }
        }
    }
}
