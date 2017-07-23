using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassEventWithCodeAnalysis :
        EditableSealedClassEvent<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>
    {
        private readonly SealedClassEventWithCodeAnalysis @event;

        public SealedPartialClassEventWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this(new SealedClassEventWithCodeAnalysis(visibility, type, name))
        {
        }

        internal SealedPartialClassEventWithCodeAnalysis(SealedClassEventWithCodeAnalysis @event)
        {
            this.@event = @event;
            @event.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public SealedClassEventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.Event.Event.Node.GetParentNode<ISealedPartialTypeWithCodeAnalysis>(); }
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

        public override SealedClassMemberInheritanceModifier InheritanceModifier
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
