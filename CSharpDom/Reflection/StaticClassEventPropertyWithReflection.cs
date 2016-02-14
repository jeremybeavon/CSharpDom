﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassEventPropertyWithReflection :
        AbstractStaticClassEventProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly EventPropertyWithReflection @event;

        internal StaticClassEventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
            this.@event = new EventPropertyWithReflection(declaringType, @event);
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
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override StaticClassMemberVisibilityModifier InheritanceModifier
        {
            get { return @event.EventInfo.AddMethod.StaticClassVisibility(); }
        }
    }
}
