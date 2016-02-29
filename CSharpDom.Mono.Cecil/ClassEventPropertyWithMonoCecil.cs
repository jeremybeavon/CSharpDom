using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassEventPropertyWithMonoCecil :
        AbstractClassEventProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>
    {
        private readonly EventPropertyWithMonoCecil @event;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal ClassEventPropertyWithMonoCecil(IInternalTypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.@event = new EventPropertyWithMonoCecil(declaringType, @event);
            this.declaringType = declaringType;
        }

        public override ILMethodBodyWithMonoCecilCil AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public override DelegateReferenceWithMonoCecil EventType
        {
            get { return @event.EventType; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return @event.EventDefinition.InheritanceModifier(declaringType); }
        }

        public override string Name
        {
            get { return @event.Name; }
        }

        public override ILMethodBodyWithMonoCecilCil RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.ClassVisibility(); }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }
    }
}
