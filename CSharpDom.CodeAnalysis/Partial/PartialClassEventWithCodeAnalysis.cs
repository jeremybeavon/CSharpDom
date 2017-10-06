using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassEventWithCodeAnalysis :
        EditableClassEvent<
            AttributeGroupWithCodeAnalysis,
            IPartialClassTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>
    {
        private readonly ClassEventWithCodeAnalysis @event;

        public PartialClassEventWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this(new ClassEventWithCodeAnalysis(visibility, type, name))
        {
        }

        internal PartialClassEventWithCodeAnalysis(ClassEventWithCodeAnalysis @event)
        {
            this.@event = @event;
            @event.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public ClassEventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.Event.Node.GetParentNode<IPartialClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> FieldAttributes
        {
            get { return @event.FieldAttributes; }
            set { @event.FieldAttributes = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.InheritanceModifier; }
            set { @event.InheritanceModifier = value; }
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
    }
}
