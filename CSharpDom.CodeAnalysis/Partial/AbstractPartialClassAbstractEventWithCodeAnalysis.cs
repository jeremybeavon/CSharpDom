﻿using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassAbstractEventWithCodeAnalysis :
        EditableAbstractEvent<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasNode<EventFieldDeclarationSyntax>
    {
        private readonly AbstractEventWithCodeAnalysis @event;

        internal AbstractPartialClassAbstractEventWithCodeAnalysis(AbstractEventWithCodeAnalysis @event)
        {
            this.@event = @event;
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
            get { return @event.Event.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.Visibility; }
            set { @event.Visibility = value; }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        INode<EventFieldDeclarationSyntax> IHasNode<EventFieldDeclarationSyntax>.Node
        {
            get { return @event.Event.Node; }
        }

        internal AbstractEventWithCodeAnalysis InternalEvent
        {
            get { return @event; }
        }
    }
}