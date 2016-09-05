using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassEventWithCodeAnalysis :
        EditableClassEvent<
            AttributeGroupWithCodeAnalysis,
            IClassType,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly EventWithCodeAnalysis @event;

        internal ClassEventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassType classType)
            : this()
        {
            @event = new EventWithCodeAnalysis(parent, this, classType);
        }

        internal ClassEventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassEventWithCodeAnalysis @event)
            : this()
        {
            this.@event = new EventWithCodeAnalysis(parent, @event);
        }

        private ClassEventWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public EventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.AttributeList.Attributes; }
            set { @event.AttributeList.Attributes = value; }
        }

        public override IClassType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> FieldAttributes
        {
            get { return @event.AttributeList.TargetedAttributes; }
            set { @event.AttributeList.TargetedAttributes = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToClassMemberInheritanceModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberInheritanceModifier(value));
            }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
