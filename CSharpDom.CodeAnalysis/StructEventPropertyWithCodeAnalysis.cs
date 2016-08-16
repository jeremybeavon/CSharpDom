using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructEventPropertyWithCodeAnalysis :
        AbstractStructEventProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>
    {
        private readonly EventPropertyWithCodeAnalysis @event;

        internal StructEventPropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.@event = new EventPropertyWithCodeAnalysis(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventDefinition.AddMethod.IsStatic ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.StructVisibility(); }
        }
    }
}
