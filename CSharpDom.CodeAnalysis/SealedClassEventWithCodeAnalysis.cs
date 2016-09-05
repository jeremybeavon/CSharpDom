using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassEventWithCodeAnalysis :
        EditableSealedClassEvent<
            AttributeGroupWithCodeAnalysis,
            ISealedType,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly ClassEventWithCodeAnalysis @event;
        
        internal SealedClassEventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            @event = new ClassEventWithCodeAnalysis(parent, this);
        }

        private SealedClassEventWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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
        
        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }
        
        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassMemberInheritanceModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassMemberInheritanceModifier(value));
            }
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
