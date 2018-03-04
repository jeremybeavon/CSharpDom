using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassAbstractEventWithCodeAnalysis :
        EditableAbstractEvent<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>
    {
        private readonly AbstractEventWithCodeAnalysis @event;

        public AbstractPartialClassAbstractEventWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this(new AbstractEventWithCodeAnalysis(visibility, type, name))
        {
        }

        internal AbstractPartialClassAbstractEventWithCodeAnalysis(AbstractEventWithCodeAnalysis @event)
        {
            this.@event = @event;
            @event.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public EventWithCodeAnalysis Event
        {
            get { return @event.Event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.Event.Node.GetParent<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }
        
        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return @event.Visibility; }
            set { @event.Visibility = value; }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        internal AbstractEventWithCodeAnalysis InternalEvent
        {
            get { return @event; }
        }
    }
}
