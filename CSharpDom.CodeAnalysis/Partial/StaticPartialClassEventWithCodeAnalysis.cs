using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassEventWithCodeAnalysis :
        EditableStaticClassEvent<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>
    {
        private readonly StaticClassEventWithCodeAnalysis @event;

        public StaticPartialClassEventWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name)
            : this(new StaticClassEventWithCodeAnalysis(visibility, type, name))
        {
        }

        internal StaticPartialClassEventWithCodeAnalysis(StaticClassEventWithCodeAnalysis @event)
        {
            this.@event = @event;
            @event.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public StaticClassEventWithCodeAnalysis Event
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return @event.Event.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
    }
}
