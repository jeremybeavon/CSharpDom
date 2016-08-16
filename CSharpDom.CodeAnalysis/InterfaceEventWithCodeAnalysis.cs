using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceEventWithCodeAnalysis :
        AbstractInterfaceEvent<
            AttributeGroupWithCodeAnalysis,
            IBasicTypeWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis>
    {
        private readonly EventDefinition @event;
        private readonly Lazy<Attributes> attributes;
        private readonly IBasicTypeWithCodeAnalysis declaringType;
        private readonly DelegateReferenceWithCodeAnalysis eventType;

        internal InterfaceEventWithCodeAnalysis(IBasicTypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.@event = @event;
            this.declaringType = declaringType;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, @event));
            eventType = new DelegateReferenceWithCodeAnalysis(assembly, @event.EventType);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IBasicTypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return eventType; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if (@event.AddMethod.IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return @event.Name; }
        }
    }
}
