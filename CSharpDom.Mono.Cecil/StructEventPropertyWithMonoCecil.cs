using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructEventPropertyWithMonoCecil :
        AbstractStructEventProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            DelegateReferenceWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>
    {
        private readonly EventPropertyWithMonoCecil @event;

        internal StructEventPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            this.@event = new EventPropertyWithMonoCecil(declaringType, @event);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> AddAttributes
        {
            get { return @event.AddAttributes; }
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
        
        public override string Name
        {
            get { return @event.Name; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }

        public override ILMethodBodyWithMonoCecilCil RemoveBody
        {
            get { return @event.RemoveBody; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return @event.EventDefinition.AddMethod.StructVisibility(); }
        }
    }
}
