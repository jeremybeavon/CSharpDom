using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructEventPropertyWithCodeAnalysis :
        EditableStructEventProperty<
            AttributeGroupWithCodeAnalysis,
            IStructType,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly EventPropertyWithCodeAnalysis @event;

        internal StructEventPropertyWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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
        
        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToStructMemberInheritanceModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberInheritanceModifier(value));
            }
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                EventDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
