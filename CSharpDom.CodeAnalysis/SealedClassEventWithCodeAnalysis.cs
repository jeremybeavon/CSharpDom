using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassEventWithCodeAnalysis :
        AbstractSealedClassEvent<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>
    {
        private readonly EventWithCodeAnalysis @event;
        private readonly IInternalTypeWithCodeAnalysis declaringType;

        internal SealedClassEventWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.@event = new EventWithCodeAnalysis(declaringType, @event);
            this.declaringType = declaringType;
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

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventDefinition.SealedClassInheritanceModifier(declaringType); }
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
