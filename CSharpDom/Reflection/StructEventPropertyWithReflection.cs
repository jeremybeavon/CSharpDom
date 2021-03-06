﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StructEventPropertyWithReflection :
        AbstractStructEventProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly EventPropertyWithReflection @event;

        internal StructEventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = new EventPropertyWithReflection(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeWithReflection> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override ILMethodBodyWithReflectionEmit AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get { return @event.EventType; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventInfo.AddMethod.IsStatic ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return @event.EventInfo.AddMethod.StructVisibility(); }
        }
    }
}
