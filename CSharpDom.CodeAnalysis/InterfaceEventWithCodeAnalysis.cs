using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceEventWithCodeAnalysis :
        EditableInterfaceEvent<
            AttributeGroupWithCodeAnalysis,
            IInterfaceTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasId
    {
        private readonly EventWithCodeAnalysis @event;
        
        internal InterfaceEventWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent)
        {
            @event = new EventWithCodeAnalysis(parent, this);
        }

        public EventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override IInterfaceTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.Node.GetParentNode<IInterfaceTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToInterfaceMemberInheritanceModifier(); }
            set { Syntax = Syntax.WithModifiers(value.ToTokens()); }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }

        public Guid InternalId
        {
            get { return ((IHasId)@event).InternalId; }
        }
    }
}
