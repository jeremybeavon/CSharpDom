using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassEventPropertyWithCodeAnalysis :
        EditableStaticClassEventProperty<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>
    {
        private readonly StaticClassEventPropertyWithCodeAnalysis @event;

        public StaticPartialClassEventPropertyWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            DelegateReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis addAccessor,
            MethodBodyWithCodeAnalysis removeAccessor)
            : this(new StaticClassEventPropertyWithCodeAnalysis(visibility, type, name, addAccessor, removeAccessor))
        {
        }

        internal StaticPartialClassEventPropertyWithCodeAnalysis(StaticClassEventPropertyWithCodeAnalysis @event)
        {
            this.@event = @event;
            @event.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public StaticClassEventPropertyWithCodeAnalysis EventProperty
        {
            get { return @event; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
            set { @event.AddAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return @event.AddBody; }
            set { @event.AddBody = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return @event.EventProperty.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
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

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
            set { @event.RemoveAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
            set { @event.RemoveBody = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
    }
}
