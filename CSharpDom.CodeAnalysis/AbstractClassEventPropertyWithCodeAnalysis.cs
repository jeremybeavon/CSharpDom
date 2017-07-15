using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassEventPropertyWithCodeAnalysis :
        EditableClassEventProperty<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>,
        IHasNode<EventDeclarationSyntax>
    {
        private readonly ClassEventPropertyWithCodeAnalysis @event;

        internal AbstractClassEventPropertyWithCodeAnalysis(ClassEventPropertyWithCodeAnalysis @event)
        {
            this.@event = @event ?? new ClassEventPropertyWithCodeAnalysis();
        }
        
        public EventPropertyWithCodeAnalysis EventProperty
        {
            get { return @event.EventProperty; }
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

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return @event.EventProperty.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToClassMemberInheritanceModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberInheritanceModifier(value));
            }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
            set { @event.RemoveBody = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
            set { @event.AddAttributes = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
            set { @event.RemoveAttributes = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
        
        INode<EventDeclarationSyntax> IHasNode<EventDeclarationSyntax>.Node
        {
            get { return @event.EventProperty.Node; }
        }

        internal ClassEventPropertyWithCodeAnalysis InternalEventProperty
        {
            get { return @event; }
        }
    }
}
