using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassEventPropertyWithReflection :
        AbstractSealedClassEventProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly EventPropertyWithReflection @event;

        internal SealedClassEventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventInfo.AddMethod.InheritanceModifier(); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override SealedClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventInfo.AddMethod.SealedClassVisibility(); }
        }
    }
}
